using Microsoft.AspNetCore.Mvc.Rendering;

using Xunit;

namespace HtmlProperties.Tests;

/// <summary>
/// The beautify tests.
/// </summary>
public class HtmlPropertiesTests
{
    /// <summary>
    /// Beautify Test with English Stack Trace
    /// </summary>
    [Fact]
    public void TestTagAndAttributes()
    {
        const string expected = """<img alt="test image" src="https://test.com/test.jpg" />""";

        // Create tag builder
        var builder = new TagBuilder(HtmlTag.Img)
        {
            TagRenderMode = TagRenderMode.SelfClosing
        };

        // Add attributes
        builder.MergeAttribute(HtmlAttribute.Src, "https://test.com/test.jpg");
        builder.MergeAttribute(HtmlAttribute.Alt, "test image");

        // Render tag
        var result = builder.RenderToString();

        Assert.Equal(expected, result);
    }
}