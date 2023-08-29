namespace DependencyInjection.Test;

using DependencyInjection;
using Xunit;

[Trait("Category","Message")]
public class MessageWriterTest
{

    [Fact]
    public void ExclaimWillWriteCorrectMessageToMessageWriter()
    {
        var writer = new SpyMessageWriter();
        var sut = new Salutation(writer);
        sut.Exclaim();

        Assert.Equal("Hello DI!", writer.WrittenMessage);
    }
}