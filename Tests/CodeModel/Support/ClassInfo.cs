﻿namespace Typewriter.Tests.CodeModel.Support
{
    [AttributeInfo]
    public class ClassInfo : BaseClassInfo, IInterfaceInfo
    {
        public ClassInfo()
        {
        }

        public const string PublicConstant = "";
        internal const string InternalConstant = "";

        public string PublicField = "";
        internal string InternalField = "";

        public static string PublicStaticField = "";
        internal static string InternalStaticField = "";

        public void PublicMethod() { }
        internal void InternalMethod() { }

        public static void PublicStaticMethod() { }
        internal static void InternalStaticMethod() { }

        public string PublicProperty { get; set; }
        internal string InternalProperty { get; set; }

        public static string PublicStaticProperty { get; set; }
        internal static string InternalStaticProperty { get; set; }

        public class NestedClassInfo
        {
            public string PublicNestedProperty { get; set; }
        }

        public interface INestedInterfaceInfo
        {
            string PublicNestedProperty { get; set; }
        }

        public enum NestedEnumInfo
        {
            NestedValue
        }
    }

    public class BaseClassInfo
    {
        public string PublicBaseProperty { get; set; }
    }

    public class GenericClassInfo<T>
    {
    }
}
