# HtmlProperties
Constants for Html Attributes and Tag Names.

[![NuGet](https://img.shields.io/nuget/v/StackTraceBeautify.svg)](https://nuget.org/packages/StackTraceBeautify) [![license](https://img.shields.io/hexpm/l/plug.svg)](#)

Instead of writing all the html tag names and/or attributes like this...

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

use the contants...

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