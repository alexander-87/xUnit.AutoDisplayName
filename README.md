# xUnit.AutoDisplayNameAttributes
Replacement `Fact` and `Theory` attributes for the [xUnit] test framework that automatically configure test method display names based upon convention.

> **Related blog post:** [Creating Readable xUnit Test Method Names Automatically]

    // TODO: Include image showing side-by-side of test results before and after.

## Installation and Usage

    // TODO: Create NuGet package

You can install this library into your test project(s) using NuGet.

> **Note:** This is only compatible with xUnit.net 2+ and .NET 4.5+.

1. Add the **xUnit.AutoDisplayNameAttributes** NuGet package to your test project(s) using the NuGet UI or by running
   the following command in the NuGet console:

    ```PowerShell
    Install-Package xUnit.AutoDisplayNameAttributes
    ```

2. Once you've the NuGet package to your project, decorate your test methods with the appropriate attribute, like so:

    > **Note:** Do not decorate your test methods with both the default XUnit.net attributes (`Fact`/`Theory`) and the attributes included in this library. The attributes in this library expand upon the default attributes.

```cSharp
using Xunit;
using Xunit.AutoDisplayNameAttributes;
 
public class SomeClassTests
{
    [Fact.FormatDisplayName.ReplaceUnderscoresWithSpaces]
    public void First_Test_Method_With_Default_Attribute_Parameters()
    {
        // This will display as "First Test Method With Default Attribute Parameters"
    }
    
    [Fact.FormatDisplayName.PascalCaseToTitleCase]
    public void MySuperAwesomeTestMethod()
    {
        // This will display as "My Super Awesome Test Method"
    }
    
    [Fact.FormatDisplayName.CamelCaseToTitleCase]
    public void yetAnotherSuperAwesomeTestMethod()
    {
        // This will display as "yet Another Super Awesome Test Method"
    }
    
    [Theory.FormatDisplayName.ReplaceUnderscoresWithSpaces]
    [InlineData("")] // An empty string
    [InlineData("\t")] // A tab
    public void Third_Test_Method_Using_xUnit_Theory_And_Inline_Data(string someStringValue)
    {
        // This will display as "Third Test Method Using xUnit Theory And Inline Data"
    }
}
```

## Supported Formats
There is support for processing 3 different test name formats.
Choose the most appropriate attribute depending upon how you prefer to format the names of your test methods.

- **Underscore word separators** *(e.g.* `My_Test_Method()` *=>* `My Test Method` *)*
    - `Fact.DisplayName.ReplaceUnderscoresWithSpaces`
    - `Theory.DisplayName.ReplaceUnderscoresWithSpaces`
- **Camel Case** *(e.g.* `myTestMethod()` *=>* `my Test Method` *)*
    - `Fact.DisplayName.CamelCaseToTitleCase`
    - `Theory.DisplayName.CamelCaseToTitleCase`
- **Pascal Case** *(e.g.* `MyTestMethod()` *=>* `My Test Method` *)*
    - `Fact.DisplayName.PascalCaseToTitleCase`
    - `Theory.DisplayName.PascalCaseToTitleCase`

> **Note:** The pascal case and camel case attributes are identical and interchangeable; they were created to allow more explicit format specifications.

## License
This code has been licensed under [The MIT License].

Refer to the [LICENSE](LICENSE.md "This project's license file.") for additional information.

## Questions, Comments or Additions

If you have a feature request or bug report, please leave an issue on the [issues page] or send a [pull request]. 

<!-- Links -->
[xUnit]: https://xunit.github.io/ "xUnit.net is a free, open source, community-focused unit testing tool for the .NET Framework."
[Creating Readable xUnit Test Method Names Automatically]: https://bitwiseguy.wordpress.com/creating-readable-xunit-test-method-names-automatically/
[The MIT License]: http://opensource.org/licenses/MIT "Information about The MIT License"
[issues page]: https://github.com/alexander-87/xUnit.AutoDisplayName/issues "GitHub Issues page for this project"
[pull request]: https://github.com/alexander-87/xUnit.AutoDisplayName/pulls "GitHub Pull Requests page for this project"