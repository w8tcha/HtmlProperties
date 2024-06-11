
using System.IO;
using System.Text.Encodings.Web;

using Microsoft.AspNetCore.Html;
using Microsoft.Extensions.WebEncoders.Testing;

namespace HtmlProperties.Tests;

/// <summary>
/// Class HtmlContentHelper.
/// </summary>
public static class HtmlContentHelper
{
    /// <summary>
    /// Render Control as String
    /// </summary>
    /// <param name="content">The content.</param>
    /// <param name="encoder">The encoder.</param>
    /// <returns>System.String.</returns>
    public static string RenderToString(this IHtmlContent content, HtmlEncoder encoder = null)
    {
        encoder ??= new HtmlTestEncoder();

        using var writer = new StringWriter();
        content.WriteTo(writer, encoder);
        return writer.ToString().Replace("HtmlEncode[[", "").Replace("]]", "");
    }
}