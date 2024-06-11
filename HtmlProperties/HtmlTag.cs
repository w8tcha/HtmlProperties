namespace HtmlProperties;

/// <summary>
/// Html tags.
/// </summary>
public struct HtmlTag
{
    /// <summary>Defines a hyperlink. </summary>
    public const string A = "a";

    /// <summary>	Defines an abbreviation or an acronym. </summary>
    public const string Abbr = "abbr";

    /// <summary>Defines an acronym. </summary>
    [Obsolete("Not supported in HTML5. Use <abbr> instead.")]
    public const string Acronym = "acronym";

    /// <summary>Defines contact information for the author/owner of a document. </summary>
    public const string Address = "address";

    /// <summary>Defines an area inside an image map. </summary>
    public const string Area = "area";

    /// <summary>Defines an article. </summary>
    public const string Article = "article";

    /// <summary>Defines content aside from the page content. </summary>
    public const string Aside = "aside";

    /// <summary>Defines embedded sound content. </summary>
    public const string Audio = "audio";

    /// <summary>Defines bold text. </summary>
    public const string B = "b";

    /// <summary>Specifies the base URL/target for all relative URLs in a document. </summary>
    public const string Base = "base";

    /// <summary>Specifies a default color, size, and font for all text in a document. </summary>
    [Obsolete("Not supported in HTML5. Use CSS instead.")]
    public const string BaseFont = "basefont";

    /// <summary>Isolates a part of text that might be formatted in a different direction from other text outside it. </summary>
    public const string Bdi = "bdi";

    /// <summary>Overrides the current text direction. </summary>
    public const string Bdo = "bdo";

    /// <summary>Defines big text. </summary>
    [Obsolete("Not supported in HTML5. Use CSS instead.")]
    public const string Big = "big";

    /// <summary>Defines a section that is quoted from another source. </summary>
    public const string Blockquote = "blockquote";

    /// <summary>	Defines the document's body. </summary>
    public const string Body = "body";

    /// <summary>Defines a single line break. </summary>
    public const string Br = "br";

    /// <summary>Defines a clickable button. </summary>
    public const string Button = "button";

    /// <summary>Used to draw graphics, on the fly, via scripting (usually JavaScript). </summary>
    public const string Canvas = "canvas";

    /// <summary>Defines a table caption </summary>
    public const string Caption = "caption";

    /// <summary>Defines centered text. </summary>
    [Obsolete("Not supported in HTML5. Use CSS instead.")]
    public const string Center = "center";

    /// <summary>Defines the title of a work. </summary>
    public const string Cite = "cite";

    /// <summary>TDefines a piece of computer code. </summary>
    public const string Code = "code";

    /// <summary>Specifies column properties for each column within a <see langword="colgroup" /> element. </summary>
    public const string Col = "col";

    /// <summary>Specifies a group of one or more columns in a table for formatting. </summary>
    public const string ColGroup = "colgroup";

    /// <summary>Adds a machine-readable translation of a given content. </summary>
    public const string Data = "data";

    /// <summary>Specifies a list of pre-defined options for input controls. </summary>
    public const string DataList = "datalist";

    /// <summary>Defines a description/value of a term in a description list. </summary>
    public const string Dd = "dd";

    /// <summary>Defines text that has been deleted from a document. </summary>
    public const string Del = "del";

    /// <summary>Defines additional details that the user can view or hide. </summary>
    public const string Details = "details";

    /// <summary>Specifies a term that is going to be defined within the content. </summary>
    public const string Dfn = "dfn";

    /// <summary>Defines a dialog box or window. </summary>
    public const string Dialog = "dialog";

    /// <summary>Defines a directory list. </summary>
    [Obsolete("Not supported in HTML5. Use <ul> instead.")]
    public const string Dir = "dir";

    /// <summary>Defines a section in a document. </summary>
    public const string Div = "div";

    /// <summary>Defines a description list. </summary>
    public const string Dl = "dl";

    /// <summary>Defines a term/name in a description list. </summary>
    public const string Dt = "dt";

    /// <summary>Defines emphasized text . </summary>
    public const string Em = "em";

    /// <summary>Defines a container for an external application. </summary>
    public const string Embed = "embed";

    /// <summary>Groups related elements in a form. </summary>
    public const string Fieldset = "fieldset";

    /// <summary>Defines a caption for a <see langword="figure" /> element. </summary>
    public const string Figcaption = "figcaption";

    /// <summary>Specifies self-contained content. </summary>
    public const string Figure = "figure";

    /// <summary>Defines font, color, and size for text. </summary>
    [Obsolete("Not supported in HTML5. Use CSS instead.")]
    public const string Font = "font";

    /// <summary>Defines a footer for a document or section. </summary>
    public const string Footer = "footer";

    /// <summary>Defines an HTML form for user input. </summary>
    public const string Form = "form";

    /// <summary>Defines a window (a frame) in a frameset. </summary>
    [Obsolete("Not supported in HTML5.")]
    public const string Frame = "frame";

    /// <summary>Defines a set of frames. </summary>
    [Obsolete("Not supported in HTML5.")]
    public const string Frameset = "frameset";

    /// <summary>Defines HTML headings. </summary>
    public const string H1 = "H1";

    /// <summary>Defines HTML headings. </summary>
    public const string H2 = "H2";

    /// <summary>Defines HTML headings. </summary>
    public const string H3 = "H3";

    /// <summary>Defines HTML headings. </summary>
    public const string H4 = "H4";

    /// <summary>Defines HTML headings. </summary>
    public const string H5 = "H5";

    /// <summary>Defines HTML headings. </summary>
    public const string H6 = "H6";

    /// <summary>Contains metadata/information for the document. </summary>
    public const string Head = "head";

    /// <summary>Defines a header for a document or section. </summary>
    public const string Header = "header";

    /// <summary>Defines a header and related content. </summary>
    public const string HGroup = "hgroup";

    /// <summary>Defines a thematic change in the content. </summary>
    public const string Hr = "hr";

    /// <summary>Defines the root of an HTML document. </summary>
    public const string Html = "html";

    /// <summary>Defines a part of text in an alternate voice or mood. </summary>
    public const string I = "i";

    /// <summary>Defines an inline frame. </summary>
    public const string Iframe = "iframe";

    /// <summary>Defines an image. </summary>
    public const string Img = "img";

    /// <summary>Defines an input control. </summary>
    public const string Input = "input";

    /// <summary>Defines a text that has been inserted into a document. </summary>
    public const string Ins = "ins";

    /// <summary>Defines keyboard input. </summary>
    public const string Kbd = "kbd";

    /// <summary>Defines a label for an <see langword="input" /> element. </summary>
    public const string Label = "label";

    /// <summary>Defines a caption for a <see langword="fieldset" /> element. </summary>
    public const string Legend = "legend";

    /// <summary>Defines a list item. </summary>
    public const string Li = "li";

    /// <summary>Defines the relationship between a document and an external resource (most used to link to style sheets). </summary>
    public const string Link = "link";

    /// <summary>Specifies the main content of a document. </summary>
    public const string Main = "main";

    /// <summary>Defines an image map. </summary>
    public const string Map = "map";

    /// <summary>Defines marked/highlighted text. </summary>
    public const string Mark = "mark";

    /// <summary>Defines an unordered list. </summary>
    public const string Menu = "menu";

    /// <summary>Defines metadata about an HTML document. </summary>
    public const string Meta = "meta";

    /// <summary>Defines a scalar measurement within a known range (a gauge). </summary>
    public const string Meter = "meter";

    /// <summary>Defines navigation links. </summary>
    public const string Nav = "nav";

    /// <summary>Defines an alternate content for users that do not support frames. </summary>
    [Obsolete("Not supported in HTML5.")]
    public const string NoFrames = "noframes";

    /// <summary>Defines an alternate content for users that do not support client-side scripts. </summary>
    public const string NoScript = "noscript";

    /// <summary>Defines a container for an external application. </summary>
    public const string Object = "object";

    /// <summary>Defines an ordered list. </summary>
    public const string Ol = "ol";

    /// <summary>Defines a group of related options in a drop-down list. </summary>
    public const string OptionGroup = "optgroup";

    /// <summary>Defines an option in a drop-down list. </summary>
    public const string Option = "option";

    /// <summary>Defines the result of a calculation. </summary>
    public const string Output = "output";

    /// <summary>Defines a paragraph. </summary>
    public const string P = "p";

    /// <summary>Defines a parameter for an object. </summary>
    public const string Param = "param";

    /// <summary>Defines a container for multiple image resources. </summary>
    public const string Picture = "picture";

    /// <summary>Defines preformatted text. </summary>
    public const string Pre = "pre";

    /// <summary>Represents the progress of a task. </summary>
    public const string Progress = "progress";

    /// <summary>Defines a short quotation. </summary>
    public const string Q = "q";

    /// <summary>Defines what to show in browsers that do not support ruby annotations. </summary>
    public const string Rb = "rb";

    /// <summary>Defines an explanation/pronunciation of characters (for East Asian typography). </summary>
    public const string Rt = "rt";

    /// <summary>Defines a ruby annotation (for East Asian typography). </summary>
    public const string Ruby = "ruby";

    /// <summary>Defines text that is no longer correct. </summary>
    public const string S = "s";

    /// <summary>Defines sample output from a computer program. </summary>
    public const string Samp = "samp";

    /// <summary>Defines a client-side script. </summary>
    public const string Script = "script";

    /// <summary>Defines a search section. </summary>
    public const string Search = "search";

    /// <summary>Defines a section in a document. </summary>
    public const string Section = "section";

    /// <summary>Defines a drop-down list. </summary>
    public const string Select = "select";

    /// <summary>Defines smaller text. </summary>
    public const string Small = "small";

    /// <summary>Defines multiple media resources for media elements (<see langword="video" /> and <see langword="audio" />). </summary>
    public const string Source = "source";

    /// <summary>Defines a section in a document. </summary>
    public const string Span = "span";

    /// <summary>Defines strikethrough text. </summary>
    [Obsolete("Not supported in HTML5. Use <del> or <s> instead.")]
    public const string Strike = "strike";

    /// <summary>Defines important text. </summary>
    public const string Strong = "strong";

    /// <summary>Defines style information for a document. </summary>
    public const string Style = "style";

    /// <summary>Defines subscripted text. </summary>
    public const string Sub = "sub";

    /// <summary>Defines a visible heading for a <see langword="details" /> element. </summary>
    public const string Summary = "summary";

    /// <summary>	Defines superscripted text. </summary>
    public const string Sup = "sup";

    /// <summary>Defines a container for SVG graphics. </summary>
    public const string Svg = "svg";

    /// <summary>Defines a table. </summary>
    public const string Table = "table";

    /// <summary>Groups the body content in a table. </summary>
    public const string Tbody = "tbody";

    /// <summary>Defines a cell in a table. </summary>
    public const string Td = "td";

    /// <summary>Defines a container for content that should be hidden when the page loads. </summary>
    public const string Template = "template";

    /// <summary>Defines a multiline input control (text area). </summary>
    public const string Textarea = "textarea";

    /// <summary>Groups the footer content in a table. </summary>
    public const string Tfoot = "tfoot";

    /// <summary>Defines a header cell in a table. </summary>
    public const string Th = "th";

    /// <summary>Groups the header content in a table. </summary>
    public const string Thead = "thead";

    /// <summary>Defines a specific time (or datetime). </summary>
    public const string Time = "time";

    /// <summary>Defines a title for the document. </summary>
    public const string Title = "title";

    /// <summary>Defines a row in a table. </summary>
    public const string Tr = "tr";

    /// <summary>Defines text tracks for media elements (<see langword="video" /> and <see langword="audio" />). </summary>
    public const string Track = "track";

    /// <summary>Defines teletype text. </summary>
    [Obsolete("Not supported in HTML5. Use CSS instead.")]
    public const string Tt = "tt";

    /// <summary>Defines some text that is unarticulated and styled differently from normal text. </summary>
    public const string U = "u";

    /// <summary>	Defines an unordered list. </summary>
    public const string Ul = "ul";

    /// <summary>Defines a variable. </summary>
    public const string Var = "var";

    /// <summary>Defines embedded video content. </summary>
    public const string Video = "video";

    /// <summary>Defines a possible line-break. </summary>
    public const string Wbr = "wbr";
}