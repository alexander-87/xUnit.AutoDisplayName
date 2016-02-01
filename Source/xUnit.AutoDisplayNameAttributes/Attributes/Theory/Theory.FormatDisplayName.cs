namespace Xunit.AutoDisplayNameAttributes
{
    /// <summary>
    ///     <para>
    ///         Marks a test method as being a data theory.
    ///     </para>
    ///     <para>
    ///         Data theories are tests which are fed various bits of data from a data source, mapping to parameters on
    ///         the test method. If the data source contains multiple rows, then the test method is executed multiple
    ///         times (once with each data row).
    ///     </para>
    ///     <para>
    ///         Data is provided by attributes which derive from <see cref="Xunit.Sdk.DataAttribute"/> (notably,
    ///         <see cref="Xunit.InlineDataAttribute"/> and <see cref="Xunit.MemberDataAttribute"/>).
    ///     </para>
    /// </summary>
    public static partial class Theory
    {
        /// <summary>
        ///     Indicates the <see cref="FactAttribute.DisplayName"/> should be automatically
        ///     configured to be the test method's name, but formatted in the specified manner.
        /// </summary>
        public static partial class FormatDisplayName { }
    }
}