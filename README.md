<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="assets/logo-wordmark-dark.svg">
    <img src="assets/logo-wordmark-light.svg" alt="HtmlProperties" width="360">
  </picture>
</p>

Constants for Html Attributes and Tag Names.

[![NuGet](https://img.shields.io/nuget/v/HtmlProperties.svg)](https://nuget.org/packages/HtmlProperties) [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Instead of writing all the html tag names and/or attributes like this...

```c#
 // Create tag builder
 var builder = new TagBuilder("img")
 {
     TagRenderMode = TagRenderMode.SelfClosing
 };

 // Add attributes
 builder.MergeAttribute("src", "https://test.com/test.jpg");
 builder.MergeAttribute("alt", "test image");
```

use the contants...

```c#
 // Create tag builder
 var builder = new TagBuilder(HtmlTag.Img)
 {
     TagRenderMode = TagRenderMode.SelfClosing
 };

 // Add attributes
 builder.MergeAttribute(HtmlAttribute.Src, "https://test.com/test.jpg");
 builder.MergeAttribute(HtmlAttribute.Alt, "test image");
```