namespace Xunit.AutoDisplayNameAttributes.UnitTests
{
    using Xunit;

    public static class Theory_FormatDisplayName_CamelCaseToTitleCaseTests
    {
        public sealed class Constructor
        {
            [Theory.FormatDisplayName.ReplaceUnderscoresWithSpaces]
            [ClassData(typeof(CamelCaseToTitleCase_Constructor_TestData))]
            public void Correctly_sets_value_of_DisplayName_property(ConstructorTestParameters testParams)
            {
                var sut = new Theory.FormatDisplayName.CamelCaseToTitleCaseAttribute(testParams.TestMethodName);

                Assert.Equal(testParams.ExpectedDisplayName, sut.DisplayName);
            }
        }
    }
}