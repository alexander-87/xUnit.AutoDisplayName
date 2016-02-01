namespace Xunit.AutoDisplayNameAttributes.UnitTests
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
    public sealed class PascalCaseToTitleCase_Constructor_TestData : ConstructorTestDataCollectionBase
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
                                TestMethodName = "MySuperAwesomeTestMethod",
                                ExpectedDisplayName = "My Super Awesome Test Method"
                            }
                };

                // Test with a single acronym
                yield return new ConstructorTestParameters[]
                {
                            new ConstructorTestParameters
                            {
                                TestMethodName = "MyHTTPTestingMethod",
                                ExpectedDisplayName = "My HTTP Testing Method"
                            }
                };

                // Multiple acronyms
                yield return new ConstructorTestParameters[]
                {
                            new ConstructorTestParameters
                            {
                                TestMethodName = "MyXMLAndHTTPWithDNSTestingMethod",
                                ExpectedDisplayName = "My XML And HTTP With DNS Testing Method"
                            }
                };

                // Some non-English characters
                yield return new ConstructorTestParameters[]
                {
                            new ConstructorTestParameters
                            {
                                TestMethodName = "TheÆvarArnfjörðBjarmason",
                                ExpectedDisplayName = "The Ævar Arnfjörð Bjarmason"
                            }
                };

                // Some more non-English characters
                yield return new ConstructorTestParameters[]
                {
                            new ConstructorTestParameters
                            {
                                TestMethodName = "IlCaffèMacchiato",
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