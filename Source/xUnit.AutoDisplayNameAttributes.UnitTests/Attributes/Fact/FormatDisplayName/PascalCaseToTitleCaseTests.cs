﻿namespace Xunit.AutoDisplayNameAttributes.UnitTests
{
    using Xunit;

    public static class Fact_FormatDisplayName_PascalCaseToTitleCaseTests
    {
        public sealed class Constructor
        {
            [Theory.FormatDisplayName.ReplaceUnderscoresWithSpaces]
            [ClassData(typeof(PascalCaseToTitleCase_Constructor_TestData))]
            public void Correctly_sets_value_of_DisplayName_property(ConstructorTestParameters testParams)
            {
                var sut = new Fact.FormatDisplayName.PascalCaseToTitleCaseAttribute(testParams.TestMethodName);

                Assert.Equal(testParams.ExpectedDisplayName, sut.DisplayName);
            }
        }
    }
}