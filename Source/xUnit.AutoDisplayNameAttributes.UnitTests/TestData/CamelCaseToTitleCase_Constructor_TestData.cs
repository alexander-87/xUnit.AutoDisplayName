namespace Xunit.AutoDisplayNameAttributes.UnitTests
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    public sealed class CamelCaseToTitleCase_Constructor_TestData : ConstructorTestDataCollectionBase
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
                                TestMethodName = "mySuperAwesomeTestMethod",
                                ExpectedDisplayName = "my Super Awesome Test Method"
                            }
                };

                // Some non-English characters
                yield return new ConstructorTestParameters[]
                {
                            new ConstructorTestParameters
                            {
                                TestMethodName = "theÆvarArnfjörðBjarmason",
                                ExpectedDisplayName = "the Ævar Arnfjörð Bjarmason"
                            }
                };

                // Some more non-English characters
                yield return new ConstructorTestParameters[]
                {
                            new ConstructorTestParameters
                            {
                                TestMethodName = "ilCaffèMacchiato",
                                ExpectedDisplayName = "il Caffè Macchiato"
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