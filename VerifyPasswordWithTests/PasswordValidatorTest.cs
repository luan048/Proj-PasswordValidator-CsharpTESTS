using Xunit;
using PasswordLib;

public class PasswordValidatorTest
{
    [Fact]
    public void PasswordWithLessCharacters()
    {
        var result = PasswordValidator.IsValid("1234567");
        Assert.False(result);
    }

    [Fact]
    public void PasswordWith8OrMoreCharacters()
    {
        var result = PasswordValidator.IsValid("12345678");
        Assert.True(result);
    }
}