namespace Xunit.AutoDisplayNameAttributes
{
    using System;
    using System.Runtime.CompilerServices;

    public static partial class Theory
    {
        public static partial class FormatDisplayName
        {
            /// <summary>
            ///     The <see cref="FactAttribute.DisplayName"/> will be set as the test method's name, but with
            ///     a space being inserted in between each uppercase character (e.g. "testMethod()" => "test Method").
            /// </summary>
            [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
            [Xunit.Sdk.XunitTestCaseDiscoverer("Xunit.Sdk.TheoryDiscoverer", "xunit.execution.{Platform}")]
            public class CamelCaseToTitleCaseAttribute : Fact.FormatDisplayName.CamelCaseToTitleCaseAttribute
            {
                /// <summary>
                ///     Creates a new instance of the <see cref="CamelCaseToTitleCaseAttribute"/> class.
                /// </summary>
                /// <param name="DisplayName">
                ///     This is automatically set to the name of the current method decorated with this attribute;
                ///     there's no need to specify a value for this parameter.
                /// </param>
                /// <example>
                /// <code lang="cs">
                /// [Theory.FormatDisplayName.CamelCaseToTitleCase, ClassData(typeof(TestData))]
                /// public void camelCaseMethod()
                /// {
                ///     // Test code goes here...
                ///     // DisplayName will be set to "camel Case Method"
                /// }
                /// </code>
                /// </example>
                public CamelCaseToTitleCaseAttribute([CallerMemberName] string DisplayName = null)
                    : base(DisplayName)
                { }
            }
        }
    }
}