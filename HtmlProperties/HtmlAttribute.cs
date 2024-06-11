namespace HtmlProperties;

/// <summary>
/// Html attributes.
/// </summary>
public struct HtmlAttribute
{
    /// <summary>Specifies the types of files that the server accepts (only for type="file")</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Input" /> .</remarks>
    public const string Accept = "accept";

    /// <summary>Specifies the character encodings that are to be used for the form submission</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Form" /> </remarks>
    public const string AcceptCharset = "accept-charset";

    /// <summary>Specifies a shortcut key to activate/focus an element</summary>
    public const string AccessKey = "accesskey";

    /// <summary>Specifies where to send the form-data when a form is submitted</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Form" /> </remarks>
    public const string Action = "action";

    /// <summary>Specifies the alignment according to surrounding elements. Use CSS instead</summary>
    [Obsolete("Not supported in HTML 5.")]
    public const string Align = "align";

    /// <summary>Specifies an alternate text when the original element fails to display</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Area" />, <see cref="HtmlTag.Img" />, <see cref="HtmlTag.Input" /> .</remarks>
    public const string Alt = "alt";

    /// <summary>Specifies that the script is executed asynchronously (only for external scripts)</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Script" /> .</remarks>
    public const string Async = "async";

    /// <summary>Specifies whether the &lt;form&gt; or the &lt;input&gt; element should have autocomplete enabled</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Form" />, <see cref="HtmlTag.Input" /> .</remarks>
    public const string Autocomplete = "autocomplete";

    /// <summary>Specifies that the element should automatically get focus when the page loads</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Button" />, <see cref="HtmlTag.Input" />, <see cref="HtmlTag.Select" />, <see cref="HtmlTag.Textarea" /> .</remarks>
    public const string Autofocus = "autofocus";

    /// <summary>Specifies that the audio/video will start playing as soon as it is ready</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Autoplay = "autoplay";

    /// <summary>Specifies that the HTML <see langword="aria-label" /> attribute be written to the tag.</summary>
    public const string AriaLabel = "aria-label";

    /// <summary>Specifies that the HTML <see langword="aria-expanded" /> attribute be written to the tag.</summary>
    public const string AriaExpanded = "aria-expanded";

    /// <summary>Specifies the background color of an element. Use CSS instead</summary>
    [Obsolete("Not supported in HTML 5.")]
    public const string Bgcolor = "bgcolor";

    /// <summary>Specifies the width of the border of an element. Use CSS instead</summary>
    [Obsolete("Not supported in HTML 5.")]
    public const string Border = "border";

    /// <summary>Specifies the character encoding</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Meta" />, <see cref="HtmlTag.Script" /> .</remarks>
    public const string Charset = "charset";

    /// <summary>Specifies that an  <see cref="HtmlTag.Input" /> element should be pre-selected when the page loads (for type="checkbox" or type = "radio")</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Input" /> .</remarks>
    public const string Checked = "checked";

    /// <summary>Specifies a URL which explains the quote/deleted/inserted text</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Blockquote" />, <see cref="HtmlTag.Del" />, <see cref="HtmlTag.Ins" />, <see cref="HtmlTag.Q" /></remarks>
    public const string Cite = "cite";

    /// <summary>Specifies one or more class names for an element (refers to a class in a style sheet)</summary>
    public const string Class = "class";

    /// <summary>Specifies the text color of an element. Use CSS instead</summary>
    [Obsolete("Not supported in HTML 5.")]
    public const string Color = "color";

    /// <summary>Specifies the visible width of a text area</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Textarea" /> .</remarks>
    public const string Cols = "cols";

    /// <summary>Specifies the number of columns a table cell should span</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Td" />, <see cref="HtmlTag.Th" /> .</remarks>
    public const string Colspan = "colspan";

    ///  <summary>Gives the value associated with the http-equiv or name attribute</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Meta" /> .</remarks>
    public const string Content = "content";

    /// <summary>Specifies whether the content of an element is editable or not</summary>
    public const string Contenteditable = "contenteditable";

    /// <summary>Specifies that audio/video controls should be displayed (such as a play/pause button etc.)</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Controls = "controls";

    /// <summary>Specifies the coordinates of the area</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Area" /> .</remarks>
    public const string Coords = "coords";

    /// <summary>Specifies the URL of the resource to be used by the object</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Object" /> .</remarks>
    public const string Data = "data";

    /// <summary>Specifies the date and time</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Del" />, <see cref="HtmlTag.Ins" />, <see cref="HtmlTag.Time" /> .</remarks>
    public const string Datetime = "datetime";

    /// <summary>Specifies that the track is to be enabled if the user's preferences do not indicate that another track would be more appropriate.</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Track" /> .</remarks>
    public const string Default = "default";

    /// <summary>Specifies that the script is executed when the page has finished parsing (only for external scripts)</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Script" /> .</remarks>
    public const string Defer = "defer";

    /// <summary>Specifies the text direction for the content in an element</summary>
    public const string Dir = "dir";

    /// <summary>Specifies that the text direction will be submitted</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Input" />, <see cref="HtmlTag.Textarea" /> .</remarks>
    public const string Dirname = "dirname";

    /// <summary>Specifies that the specified element/group of elements should be disabled</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Button" />, <see cref="HtmlTag.fieldsetfieldset" />,
    /// <see cref="HtmlTag.Input" />, <see cref="HtmlTag.OptionGroup" />, <see cref="HtmlTag.Option" />,
    /// <see cref="HtmlTag.Select" />, <see langword = "textareatextarea" /> .</remarks>
    public const string Disabled = "disabled";

    /// <summary>Specifies that the target will be downloaded when a user clicks on the hyperlink</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.A" />, <see cref="HtmlTag.Area" /> .</remarks>
    public const string Download = "download";

    /// <summary>Specifies whether an element is draggable or not</summary>
    public const string Draggable = "draggable";

    /// <summary>Specifies how the form-data should be encoded when submitting it to the server(only for method= "post")</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Form" /> .</remarks>
    public const string Enctype = "enctype";

    /// <summary>Specifies the text of the enter-key on a virtual keyboard</summary>
    public const string Enterkeyhint = "enterkeyhint";

    /// <summary>Specifies which form element(s) a label/calculation is bound to</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Label" />, <see cref="HtmlTag.Output" /> .</remarks>
    public const string For = "for";

    /// <summary>Specifies the name of the form the element belongs to</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Button" />, <see cref="HtmlTag.Fieldset" />,
    /// <see cref="HtmlTag.Input" />, <see cref="HtmlTag.Label" />,
    /// <see cref="HtmlTag.Meter" />, <see cref="HtmlTag.Object" />, <see cref="HtmlTag.Output" />,
    /// <see cref="HtmlTag.Select" />, <see cref="HtmlTag.Textarea" /> .</remarks>
    public const string Form = "form";

    /// <summary>Specifies where to send the form-data when a form is submitted. Only for type="submit"</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Button" />, <see cref="HtmlTag.Input" /> .</remarks>
    public const string Formaction = "formaction";

    /// <summary>Specifies one or more headers cells a cell is related to</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Td" />, <see cref="HtmlTag.Th" /> .</remarks>
    public const string Headers = "headers";

    /// <summary>Specifies the height of the element</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Canvas" />, <see cref="HtmlTag.Embed" />,
    /// <see cref="HtmlTag.Iframe" />, <see cref="HtmlTag.Img" />,
    /// <see cref="HtmlTag.Input" />, <see cref="HtmlTag.Object" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Height = "height";

    /// <summary>Specifies that an element is not yet, or is no longer, relevant</summary>
    public const string Hidden = "hidden";

    /// <summary>Specifies the range that is considered to be a high value</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Meter" /> .</remarks>
    public const string High = "high";

    /// <summary>Specifies the URL of the page the link goes to</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.A" />, <see cref="HtmlTag.Area" />,
    /// <see cref="HtmlTag.Base" />, <see cref="HtmlTag.Link" /> .</remarks>
    public const string Href = "href";

    /// <summary>Specifies the language of the linked document</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.A" />, <see cref="HtmlTag.Area" />, <see cref="HtmlTag.Link" /> .</remarks>
    public const string Hreflang = "hreflang";

    /// <summary>Provides an HTTP header for the information/value of the content attribute</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Meta" /> .</remarks>
    public const string HttpEquiv = "http-equiv";

    /// <summary>Specifies a unique id for an element</summary>
    public const string Id = "id";

    /// <summary>Specifies that the browser should ignore this section</summary>
    public const string Inert = "inert";

    /// <summary>Specifies the mode of a virtual keyboard</summary>
    public const string InputMode = "inputmode";

    /// <summary>Specifies an image as a server-side image map</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Img" /> .</remarks>
    public const string Ismap = "ismap";

    /// <summary>Specifies the kind of text track</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Track" /> .</remarks>
    public const string Kind = "kind";

    /// <summary>Specifies the title of the text track</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Track" />, <see cref="HtmlTag.Option" />, <see cref="HtmlTag.OptionGroup" /> .</remarks>
    public const string Label = "label";

    /// <summary>Specifies the language of the element's content</summary>
    public const string Lang = "lang";

    /// <summary>Refers to a <see cref="HtmlTag.DataList" /> element that contains pre-defined options for an <see cref="HtmlTag.Input" /> element</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Input" /> .</remarks>
    public const string List = "list";

    /// <summary>Specifies that the audio/video will start over again, every time it is finished</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Loop = "loop";

    /// <summary>Specifies the range that is considered to be a low value</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Meter" /> .</remarks>
    public const string Low = "low";

    /// <summary>Specifies the maximum value</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Input" />, <see cref="HtmlTag.Meter" />, <see cref="HtmlTag.Progress" /> .</remarks>
    public const string Max = "max";

    /// <summary>Specifies the maximum number of characters allowed in an element</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Input" />, <see cref="HtmlTag.Textarea" /> .</remarks>
    public const string Maxlength = "maxlength";

    /// <summary>Specifies what media/device the linked document is optimized for</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.A" />, <see cref="HtmlTag.Area" />, <see cref="HtmlTag.Link" />,
    /// <see cref="HtmlTag.Source" />, <see cref="HtmlTag.Style" /> </remarks>.
    public const string Media = "media";

    /// <summary>Specifies the HTTP method to use when sending form-data</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Form" /> .</remarks>
    public const string Method = "method";

    /// <summary>Specifies a minimum value</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Input" />, <see cref="HtmlTag.Meter" /> .</remarks>
    public const string Min = "min";

    /// <summary>Specifies that a user can enter more than one value</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Input" />, <see cref="HtmlTag.Select" /> .</remarks>
    public const string Multiple = "multiple";

    /// <summary>Specifies that the audio output of the video should be muted</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Video" />, <see cref="HtmlTag.Audio" /> .</remarks>
    public const string Muted = "muted";

    /// <summary>Specifies the name of the element</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Button" />, <see cref="HtmlTag.Fieldset" />,
    /// <see cref="HtmlTag.Form" />, <see cref="HtmlTag.Iframe" />, <see cref="HtmlTag.Input" />,
    /// <see cref="HtmlTag.Map" />, <see cref="HtmlTag.Meta" />, <see cref="HtmlTag.Object" />,
    /// <see cref="HtmlTag.Output" />, <see cref="HtmlTag.Param" />, <see cref="HtmlTag.Select" />,
    /// <see cref="HtmlTag.Textarea" /> .</remarks>
    public const string Name = "name";

    /// <summary>Specifies that the form should not be validated when submitted</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Form" /> .</remarks>
    public const string Novalidate = "novalidate";

    /// <summary>Script to be run on abort</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Embed" />,
    /// <see cref="HtmlTag.Img" />, <see cref="HtmlTag.Object" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onabort = "onabort";

    /// <summary>Script to be run after the document is printed</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Body" /> .</remarks>
    public const string Onafterprint = "onafterprint";

    /// <summary>Script to be run before the document is printed</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Body" /> .</remarks>
    public const string Onbeforeprint = "onbeforeprint";

    /// <summary>Script to be run when the document is about to be unloaded</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Body" /> .</remarks>
    public const string Onbeforeunload = "onbeforeunload";

    /// <summary>Script to be run when the element loses focus</summary>
    public const string Onblur = "onblur";

    /// <summary>Script to be run when a file is ready to start playing (when it has buffered enough to begin)</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Embed" />,
    /// <see cref="HtmlTag.Object" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Oncanplay = "oncanplay";

    /// <summary>Script to be run when a file can be played all the way to the end without pausing for buffering</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Oncanplaythrough = "oncanplaythrough";

    /// <summary>Script to be run when the value of the element is changed</summary>
    public const string Onchange = "onchange";

    /// <summary>Script to be run when the element is being clicked</summary>
    public const string Onclick = "onclick";

    /// <summary>Script to be run when a context menu is triggered</summary>
    public const string Oncontextmenu = "oncontextmenu";

    /// <summary>Script to be run when the content of the element is being copied</summary>
    public const string Oncopy = "oncopy";

    /// <summary>Script to be run when the cue changes in a <see cref="HtmlTag.Track" /> element</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Track" /> .</remarks>
    public const string Oncuechange = "oncuechange";

    /// <summary>Script to be run when the content of the element is being cut</summary>
    public const string Oncut = "oncut";

    /// <summary>Script to be run when the element is being double-clicked</summary>
    public const string Ondblclick = "ondblclick";

    /// <summary>Script to be run when the element is being dragged</summary>
    public const string Ondrag = "ondrag";

    /// <summary>Script to be run at the end of a drag operation</summary>
    public const string Ondragend = "ondragend";

    /// <summary>Script to be run when an element has been dragged to a valid drop target</summary>
    public const string Ondragenter = "ondragenter";

    /// <summary>Script to be run when an element leaves a valid drop target</summary>
    public const string Ondragleave = "ondragleave";

    /// <summary>Script to be run when an element is being dragged over a valid drop target</summary>
    public const string Ondragover = "ondragover";

    /// <summary>Script to be run at the start of a drag operation</summary>
    public const string Ondragstart = "ondragstart";

    /// <summary>Script to be run when dragged element is being dropped</summary>
    public const string Ondrop = "ondrop";

    /// <summary>Script to be run when the length of the media changes</summary>
    /// /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Ondurationchange = "ondurationchange";

    /// <summary>Script to be run when something bad happens and the file is suddenly unavailable(like unexpectedly disconnects)</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onemptied = "onemptied";

    /// <summary>Script to be run when the media has reach the end (a useful event for messages like "thanks for listening")</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onended = "onended";

    /// <summary>Script to be run when an error occurs</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Body" />,
    /// <see cref="HtmlTag.Embed" />, <see cref="HtmlTag.Img" />, <see cref="HtmlTag.Object" />,
    /// <see cref="HtmlTag.Script" />, <see cref="HtmlTag.Style" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onerror = "onerror";

    /// <summary>Script to be run when the element gets focus</summary>
    public const string Onfocus = "onfocus";

    /// <summary>Script to be run when there has been changes to the anchor part of the URL</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Body" /> .</remarks>
    public const string Onhashchange = "onhashchange";

    /// <summary>Script to be run when the element gets user input</summary>
    public const string Oninput = "oninput";

    /// <summary>Script to be run when the element is invalid</summary>
    public const string Oninvalid = "oninvalid";

    /// <summary>Script to be run when a user is pressing a key</summary>
    public const string Onkeydown = "onkeydown";

    /// <summary>Script to be run when a user presses a key</summary>
    public const string Onkeypress = "onkeypress";

    /// <summary>Script to be run when a user releases a key</summary>
    public const string Onkeyup = "onkeyup";

    /// <summary>Script to be run when the element is finished loading</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Body" />, <see cref="HtmlTag.Iframe" />,
    /// <see cref="HtmlTag.Img" />, <see cref="HtmlTag.Input" />, <see cref="HtmlTag.Link" />,
    /// <see cref="HtmlTag.Script" />, <see cref="HtmlTag.Style" /> .</remarks>
    public const string Onload = "onload";

    /// <summary>Script to be run when media data is loaded</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onloadeddata = "onloadeddata";

    /// <summary>Script to be run when meta data (like dimensions and duration) are loaded</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onloadedmetadata = "onloadedmetadata";

    /// <summary>Script to be run just as the file begins to load before anything is actually loaded</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onloadstart = "onloadstart";

    /// <summary>Script to be run when a mouse button is pressed down on an element</summary>
    public const string Onmousedown = "onmousedown";

    /// <summary>Script to be run as long as the mouse pointer is moving over an element</summary>
    public const string Onmousemove = "onmousemove";

    /// <summary>Script to be run when a mouse pointer moves out of an element</summary>
    public const string Onmouseout = "onmouseout";

    /// <summary>Script to be run when a mouse pointer moves over an element</summary>
    public const string Onmouseover = "onmouseover";

    /// <summary>Script to be run when a mouse button is released over an element</summary>
    public const string Onmouseup = "onmouseup";

    /// <summary>Script to be run when a mouse wheel is being scrolled over an element</summary>
    public const string Onmousewheel = "onmousewheel";

    /// <summary>Script to be run when the browser starts to work offline</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Body" /> .</remarks>
    public const string Onoffline = "onoffline";

    /// <summary>Script to be run when the browser starts to work online</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Body" /> .</remarks>
    public const string Ononline = "ononline";

    /// <remarks>Only Valid for <see cref="HtmlTag.Body" /> .</remarks>
    /// <summary>Script to be run when a user navigates away from a page</summary>
    public const string Onpagehide = "onpagehide";

    /// <summary>Script to be run when a user navigates to a page</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Body" /> .</remarks>
    public const string Onpageshow = "onpageshow";

    /// <summary>Script to be run when the user pastes some content in an element</summary>
    public const string Onpaste = "onpaste";

    /// <summary>Script to be run when the media is paused either by the user or programmatically</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onpause = "onpause";

    /// <summary>Script to be run when the media has started playing</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onplay = "onplay";

    /// <summary>Script to be run when the media has started playing</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onplaying = "onplaying";

    /// <summary>Script to be run when the window's history changes.</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Body" /> .</remarks>
    public const string Onpopstate = "onpopstate";

    /// <summary>Script to be run when the browser is in the process of getting the media data</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onprogress = "onprogress";

    /// <summary>Script to be run each time the playback rate changes (like when a user switches to a slow motion or fast forward mode).</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onratechange = "onratechange";

    /// <summary>Script to be run when a reset button in a form is clicked.</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Form" /> .</remarks>
    public const string Onreset = "onreset";

    /// <summary>Script to be run when the browser window is being resized.</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Body" /> .</remarks>
    public const string Onresize = "onresize";

    /// <summary>Script to be run when an element's scrollbar is being scrolled</summary>
    public const string Onscroll = "onscroll";

    /// <summary>Script to be run when the user writes something in a search field (for &lt;input type = "search" & gt;)</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Input" /> .</remarks>
    public const string Onsearch = "onsearch";

    /// <summary>Script to be run when the seeking attribute is set to false indicating that seeking has ended</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onseeked = "onseeked";

    /// <summary>Script to be run when the seeking attribute is set to true indicating that seeking is active</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onseeking = "onseeking";

    /// <summary>Script to be run when the element gets selected</summary>
    public const string Onselect = "onselect";

    /// <summary>Script to be run when the browser is unable to fetch the media data for whatever reason</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onstalled = "onstalled";

    /// <summary>Script to be run when a Web Storage area is updated</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Body" /> .</remarks>
    public const string Onstorage = "onstorage";

    /// <summary>Script to be run when a form is submitted</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Form" /> .</remarks>
    public const string Onsubmit = "onsubmit";

    /// <summary>Script to be run when fetching the media data is stopped before it is completely loaded for whatever reason</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onsuspend = "onsuspend";

    /// <summary>Script to be run when the playing position has changed (like when the user fast forwards to a different point in the media)</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Ontimeupdate = "ontimeupdate";

    /// <summary>Script to be run when the user opens or closes the &lt;details&gt; element</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Details" /> .</remarks>
    public const string Ontoggle = "ontoggle";

    /// <summary>Script to be run when a page has unloaded (or the browser window has been closed)</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Body" /> .</remarks>
    public const string Onunload = "onunload";

    /// <summary>Script to be run each time the volume of a video/audio has been changed</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onvolumechange = "onvolumechange";

    /// <summary>Script to be run when the media has paused but is expected to resume (like when the media pauses to buffer more data)</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Onwaiting = "onwaiting";

    /// <summary>Script to be run when the mouse wheel rolls up or down over an element</summary>
    public const string Onwheel = "onwheel";

    /// <summary>Specifies that the details should be visible (open) to the user</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Details" /> .</remarks>
    public const string Open = "open";

    /// <summary>Specifies what value is the optimal value for the gauge</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Meter" /> .</remarks>
    public const string Optimum = "optimum";

    /// <summary>Specifies a regular expression that an <see cref="HtmlTag.Input" /> element's value is checked against</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Input" /> .</remarks>
    public const string Pattern = "pattern";

    /// <summary>Specifies a short hint that describes the expected value of the element</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Input" />, <see cref="HtmlTag.Textarea" /> .</remarks>
    public const string Placeholder = "placeholder";

    /// <summary>Specifies a popover element</summary>
    public const string Popover = "popover";

    /// <summary>Specifies which popover element to invoke</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Button" />, <see cref="HtmlTag.Input" /> .</remarks>
    public const string Popovertarget = "popovertarget";

    /// <remarks>Only Valid for <see cref="HtmlTag.Button" />, <see cref="HtmlTag.Input" /> .</remarks>
    /// <summary>Specifies what happens to the popover element when the button is clicked</summary>
    public const string Popovertargetaction = "popovertargetaction";

    /// <summary>Specifies an image to be shown while the video is downloading, or until the user hits the play button</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Video" /> .</remarks>
    public const string Poster = "poster";

    /// <summary>Specifies if and how the author thinks the audio/video should be loaded when the page loads</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Video" /> .</remarks>
    public const string Preload = "preload";

    /// <summary>Specifies that the element is read-only</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Input" />, <see cref="HtmlTag.Textarea" /> .</remarks>
    public const string Readonly = "readonly";

    /// <summary>Specifies the relationship between the current document and the linked document </ summary >
    /// <remarks>Only Valid for <see cref="HtmlTag.A" />, <see cref="HtmlTag.Area" />, <see langword = "formform" />, <see langword = "linklink" /> .</remarks>
    public const string Rel = "rel";

    /// <summary>Specifies that the element must be filled out before submitting the form</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Input" />, <see cref="HtmlTag.Select" />, <see cref="HtmlTag.Textarea" /> .</remarks>
    public const string Required = "required";

    /// <summary>Specifies that the list order should be descending (9,8,7...)</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Ol" /> .</remarks>
    public const string Reversed = "reversed";

    /// <summary>Specifies that the HTML <see langword="role" /> attribute be written to the tag.</summary>
    public const string Role = "role";

    /// <summary>Specifies the visible number of lines in a text area</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Textarea" /> .</remarks>
    public const string Rows = "rows";

    /// <summary>Specifies the number of rows a table cell should span</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Td" />, <see cref="HtmlTag.Th" /> .</remarks>
    public const string Rowspan = "rowspan";

    /// <summary>Enables an extra set of restrictions for the content in an <see cref="HtmlTag.Iframe" /></summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Iframe" /> .</remarks>
    public const string Sandbox = "sandbox";

    /// <summary>Specifies whether a header cell is a header for a column, row, or group of columns or rows</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Th" /> .</remarks>
    public const string Scope = "scope";

    /// <summary>Specifies that an option should be pre-selected when the page loads</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Option" /> .</remarks>
    public const string Selected = "selected";

    /// <summary>Specifies the shape of the area</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Area" /> .</remarks>
    public const string Shape = "shape";

    /// <summary>Specifies the width, in characters (for &lt;input&gt;) or specifies the number of visible options(for &lt; select&gt;)</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Input" />, <see cref="HtmlTag.Select" /> .</remarks>
    public const string Size = "size";

    /// <summary>Specifies the size of the linked resource</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Img" />, <see cref="HtmlTag.Link" />,<see langword = "sourcesource" /> .</remarks>
    public const string Sizes = "sizes";

    /// <summary>Specifies the number of columns to span</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Col" />, <see cref="HtmlTag.ColGroup" /> .</remarks>
    public const string Span = "span";

    /// <summary>Specifies whether the element is to have its spelling and grammar checked or not</summary>
public const string Spellcheck = "spellcheck";

    /// <summary>Specifies the URL of the media file</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Audio" />, <see cref="HtmlTag.Embed" />, <see cref="HtmlTag.Iframe" />,
    /// <see cref="HtmlTag.Img" />, <see cref="HtmlTag.Input" />, <see cref="HtmlTag.Script" />,
    /// <see cref="HtmlTag.Source" />, <see cref="HtmlTag.Track" />, <see langword = "videovideo" /> .</remarks>
    public const string Src = "src";

    /// <summary>Specifies the HTML content of the page to show in the &lt;iframe&gt;</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Iframe" /> .</remarks>
    public const string Srcdoc = "srcdoc";

    /// <summary>Specifies the language of the track text data (required if kind="subtitles")</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Track" /> .</remarks>
    public const string Srclang = "srclang";

    /// <summary>Specifies the URL of the image to use in different situations</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Img" />, <see cref="HtmlTag.Source" /> .</remarks>
    public const string Srcset = "srcset";

    /// <summary>Specifies the start value of an ordered list</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Ol" /> .</remarks>
    public const string Start = "start";

    /// <summary>Specifies the legal number intervals for an input field</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Input" /> .</remarks>
    public const string Step = "step";

    /// <summary>Specifies an inline CSS style for an element</summary>
    public const string Style = "style";

    /// <summary>Specifies the tabbing order of an element</summary>
    public const string Tabindex = "tabindex";

    /// <summary>Specifies the target for where to open the linked document or where to submit the form</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.A" />, <see cref="HtmlTag.Area" />,
    /// <see cref="HtmlTag.Base" />, <see cref="HtmlTag.Form" /> .</remarks>
    public const string Target = "target";

    /// <summary>Specifies extra information about an element</summary>
    public const string Title = "title";

    /// <summary>Specifies whether the content of an element should be translated or not</summary>
    public const string Translate = "translate";

    /// <summary>Specifies the type of element</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.A" />, <see  cref="HtmlTag.Button" />,
    /// <see cref="HtmlTag.Embed" />, <see  cref="HtmlTag.Input" />, <see  cref="HtmlTag.Link" />,
    /// <see cref="HtmlTag.Menu" />, <see cref="HtmlTag.Object" />, <see  cref="HtmlTag.Script" />,
    /// <see cref="HtmlTag.Source" />, <see  cref="HtmlTag.Style" />.</remarks>
    public const string Type = "type";

    /// <summary>Specifies an image as a client-side image map</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Img" />, <see cref="HtmlTag.Object" /> .</remarks>
    public const string UseMap = "usemap";

    /// <summary>Specifies the value of the element</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Button" />, <see cref="HtmlTag.Input" />,
    /// <see cref="HtmlTag.Li" />, <see cref="HtmlTag.Option" />, <see langword = "metermeter" />,
    /// <see langword = "progressprogress" />, <see langword = "paramparam" /> .</remarks>
    public const string Value = "value";

    /// <summary>Specifies the width of the element</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Canvas" />, <see cref="HtmlTag.Embed" />, <see cref="HtmlTag.Iframe" />,
    /// <see cref="HtmlTag.Img" />, <see cref="HtmlTag.Input" />, <see cref="HtmlTag.Object" />,
    /// <see cref="HtmlTag.Video" /> .</remarks>
    public const string Width = "width";

    /// <summary>Specifies how the text in a text area is to be wrapped when submitted in a form</summary>
    /// <remarks>Only Valid for <see cref="HtmlTag.Textarea" /> .</remarks>
    public const string Wrap = "wrap";
}