using System;
using System.Collections.Generic;
using System.Linq;
using EnvDTE;
using EnvDTE80;
using Typewriter.Metadata.Interfaces;

namespace Typewriter.Metadata.CodeDom
{
    public class CodeDomEnumValueMetadata : IEnumValueMetadata
    {
        private readonly CodeVariable2 codeVariable;
        private readonly CodeDomFileMetadata file;
        private readonly int value;

        private CodeDomEnumValueMetadata(CodeVariable2 codeVariable, CodeDomFileMetadata file, int value)
        {
            this.codeVariable = codeVariable;
            this.file = file;
            this.value = value;
        }
        
        public string Name => codeVariable.Name;
        public string FullName => codeVariable.FullName;
        public int Value => value;
        public IEnumerable<IAttributeMetadata> Attributes => CodeDomAttributeMetadata.FromCodeElements(codeVariable.Attributes, file);
        
        internal static IEnumerable<IEnumValueMetadata> FromCodeElements(CodeElements codeElements, CodeDomFileMetadata file)
        {
            var value = -1;

            foreach (var codeVariable in codeElements.OfType<CodeVariable2>())
            {
                if (codeVariable.InitExpression == null)
                    value++;
                else
                    value = Convert.ToInt32(codeVariable.InitExpression);

                yield return new CodeDomEnumValueMetadata(codeVariable, file, value);
            }
        }
    }
}