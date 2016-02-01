namespace Xunit.AutoDisplayNameAttributes.UnitTests
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    public sealed class ReplaceUnderscoresWithSpaces_Constructor_TestData : ConstructorTestDataCollectionBase
    {
        protected override System.Collections.Generic.IEnumerable<ConstructorTestParameters[]> Data
        {
            get
            {
                // Simple replacement of underscores with spaces
                yield return new ConstructorTestParameters[]
                {
                            new ConstructorTestParameters
                            {
                                TestMethodName = "My_Super_Awesome_Test_Method",
                                ExpectedDisplayName = "My Super Awesome Test Method"
                            }
                };

                // Some non-English characters
                yield return new ConstructorTestParameters[]
                {
                            new ConstructorTestParameters
                            {
                                TestMethodName = "The_Ævar_Arnfjörð_Bjarmason",
                                ExpectedDisplayName = "The Ævar Arnfjörð Bjarmason"
                            }
                };

                // Some more non-English characters
                yield return new ConstructorTestParameters[]
                {
                            new ConstructorTestParameters
                            {
                                TestMethodName = "Il_Caffè_Macchiato",
                                ExpectedDisplayName = "Il Caffè Macchiato"
                            }
                };

                // Sets DisplayName to null (the default value) when TestMethodName is null
                yield return new ConstructorTestParameters[]
                {
                            new ConstructorTestParameters
                            {
                                TestMethodName = null,
                                ExpectedDisplayName = null
                            }
                };
            }
        }
    }
}