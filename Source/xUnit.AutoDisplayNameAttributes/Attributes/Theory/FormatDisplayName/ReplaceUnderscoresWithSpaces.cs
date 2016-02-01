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
            ///     underscores being replaced with a space (e.g. "Test_Method()" => "Test Method").
            /// </summary>
            [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
            [Xunit.Sdk.XunitTestCaseDiscoverer("Xunit.Sdk.TheoryDiscoverer", "xunit.execution.{Platform}")]
            public class ReplaceUnderscoresWithSpacesAttribute : Fact.FormatDisplayName.ReplaceUnderscoresWithSpacesAttribute
            {
                /// <summary>
                ///     Creates a new instance of the <see cref="ReplaceUnderscoresWithSpacesAttribute"/> class.
                /// </summary>
                /// <param name="DisplayName">
                ///     This is automatically set to the name of the current method decorated with this attribute;
                ///     there's no need to specify a value for this parameter.
                /// </param>
                /// <example>
                /// <code lang="cs">
                /// [Theory.FormatDisplayName.ReplaceUnderscoresWithSpacesAttribute, ClassData(typeof(TestData))]
                /// public void Title_Case_Method_with_Underscores()
                /// {
                ///     // Test code goes here...
                ///     // DisplayName will be set to "Title Case Method with Underscores"
                /// }
                /// </code>
                /// </example>
                public ReplaceUnderscoresWithSpacesAttribute([CallerMemberName] string DisplayName = null)
                    : base(DisplayName)
                { }
            }
        }
    }
}