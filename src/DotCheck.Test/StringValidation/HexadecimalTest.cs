using DotCheck.StringValidation.StringExtensions;
using DotCheck.Test.StringValidation.TestData;

namespace DotCheck.Test.StringValidation;

public class HexadecimalTest
{
    [Fact]
    public void IsHexadecimal() =>
        HexadecimalData.Valid.All(x => x.IsHexadecimal()).ShouldBeTrue();

    [Fact]
    public void IsNotHexadecimal() =>
        HexadecimalData.Invalid.All(x => x.IsHexadecimal()).ShouldBeFalse();
}