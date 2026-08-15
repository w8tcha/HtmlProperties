using AwesomeAssertions;

using Microsoft.AspNetCore.Mvc.Rendering;

using NUnit.Framework;


namespace HtmlProperties.Tests;

/// <summary>
/// The beautify tests.
/// </summary>
public class HtmlPropertiesTests
{
    /// <summary>
    /// Beautify Test with English Stack Trace
    /// </summary>
    [Test]
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

        result.Should().Be(expected);
    }
}