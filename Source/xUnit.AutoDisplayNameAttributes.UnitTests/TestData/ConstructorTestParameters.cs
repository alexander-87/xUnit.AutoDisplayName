namespace Xunit.AutoDisplayNameAttributes.UnitTests
{
    /// <summary>Simple POCO for passing data to test methods when testing the attribute constructors.</summary>
    public sealed class ConstructorTestParameters
    {
        /// <summary>Gets or sets the name of the test method.</summary>
        public string TestMethodName { get; set; }

        /// <summary>Gets or sets the expected value of the <see cref="FactAttribute.DisplayName"/>.</summary>
        public string ExpectedDisplayName { get; set; }
    }
}