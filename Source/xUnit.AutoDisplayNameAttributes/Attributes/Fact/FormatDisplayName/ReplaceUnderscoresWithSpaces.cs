namespace Xunit.AutoDisplayNameAttributes
{
    using System;
    using System.Runtime.CompilerServices;

    public static partial class Fact
    {
        public static partial class FormatDisplayName
        {
            /// <summary>
            ///     The <see cref="FactAttribute.DisplayName"/> will be set as the test method's name, but with
            ///     underscores being replaced with a space (e.g. "Test_Method()" => "Test Method").
            /// </summary>
            [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
            [Xunit.Sdk.XunitTestCaseDiscoverer("Xunit.Sdk.FactDiscoverer", "xunit.execution.{Platform}")]
            public class ReplaceUnderscoresWithSpacesAttribute : FactAttribute
            {
                /// <summary>
                ///     Creates a new instance of the <see cref="ReplaceUnderscoresWithSpacesAttribute"/> class.
                /// </summary>
                /// <param name="DisplayName">
                ///     This is automatically set to the name of the current method decorated with this attribute;
                ///     there's no need to specify a value for this parameter.
                /// </param>
                public ReplaceUnderscoresWithSpacesAttribute([CallerMemberName] string DisplayName = null)
                {
                    base.DisplayName = DisplayName?.Replace("_", " ");
                }
            }
        }
    }
}