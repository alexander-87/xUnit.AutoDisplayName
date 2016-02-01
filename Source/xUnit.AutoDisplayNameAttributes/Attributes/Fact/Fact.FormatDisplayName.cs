namespace Xunit.AutoDisplayNameAttributes
{
    /// <summary>
    ///     Attribute that is applied to a method to indicate that it is a fact that should be run by the test runner.
    /// </summary>
    public static partial class Fact
    {
        /// <summary>
        ///     Indicates the <see cref="FactAttribute.DisplayName"/> should be automatically
        ///     configured to be the test method's name, but formatted in the specified manner.
        /// </summary>
        public static partial class FormatDisplayName { }
    }
}