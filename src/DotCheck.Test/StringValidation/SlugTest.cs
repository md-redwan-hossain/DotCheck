using DotCheck.StringValidation.StringExtensions;
using DotCheck.Test.StringValidation.TestData;

namespace DotCheck.Test.StringValidation;

public class SlugTest
{
    [Fact]
    public void IsSlug() =>
        SlugData.Valid.All(x => x.IsSlug()).ShouldBeTrue();

    [Fact]
    public void IsNotSlug() =>
        SlugData.Invalid.All(x => x.IsSlug()).ShouldBeFalse();
}