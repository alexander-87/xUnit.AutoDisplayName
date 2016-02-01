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
            ///     a space being inserted in between each uppercase character (e.g. "TestMethod()" => "Test Method").
            /// </summary>
            [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
            [Xunit.Sdk.XunitTestCaseDiscoverer("Xunit.Sdk.FactDiscoverer", "xunit.execution.{Platform}")]
            public class PascalCaseToTitleCaseAttribute : FactAttribute
            {
                /// <summary>
                ///     Creates a new instance of the <see cref="PascalCaseToTitleCaseAttribute"/> class.
                /// </summary>
                /// <param name="DisplayName">
                ///     This is automatically set to the name of the current method decorated with this attribute;
                ///     there's no need to specify a value for this parameter.
                /// </param>
                /// <example>
                /// <code lang="cs">
                /// [Fact.FormatDisplayName.PascalCaseToTitleCase]
                /// public void PascalCaseMethod()
                /// {
                ///     // Test code goes here...
                ///     // DisplayName will be set to "Pascal Case Method"
                /// }
                /// </code>
                /// </example>
                public PascalCaseToTitleCaseAttribute([CallerMemberName] string DisplayName = null)
                {
                    base.DisplayName = ConvertStringFromPascalCaseToTitleCase(DisplayName);
                }

                /// <seealso cref="http://stackoverflow.com/a/12732616/1796930">
                ///     Original source code for this method (Stack Overflow: Add spaces before Capital Letters).
                /// </seealso>
                private static string ConvertStringFromPascalCaseToTitleCase(string pascalCaseText)
                {
                    if (String.IsNullOrWhiteSpace(pascalCaseText))
                        return pascalCaseText;

                    var originalStringLength = pascalCaseText.Length;
                    var newText = new System.Text.StringBuilder(originalStringLength * 2);
                    newText.Append(pascalCaseText[0]);

                    // Loop through every character and insert a space if the subsequent character
                    // is uppercase, taking into consideration acronyms (e.g. "DNS", "HTML", "XML").
                    for (var i = 1; i < originalStringLength; i++)
                    {
                        var currentUpper = Char.IsUpper(pascalCaseText[i]);
                        var prevUpper = Char.IsUpper(pascalCaseText[i - 1]);
                        var nextUpper = originalStringLength > i + 1
                                      ? Char.IsUpper(pascalCaseText[i + 1]) || Char.IsWhiteSpace(pascalCaseText[i + 1])
                                      : prevUpper;

                        var spaceExists = Char.IsWhiteSpace(pascalCaseText[i - 1]);
                        if (currentUpper && !spaceExists && (!nextUpper || !prevUpper))
                        {
                            newText.Append(' ');
                        }

                        newText.Append(pascalCaseText[i]);
                    }
                    return newText.ToString();
                }
            }
        }
    }
}