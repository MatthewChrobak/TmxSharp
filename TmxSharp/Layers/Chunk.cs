using System.Xml.Serialization;

namespace TmxSharp.Layers;

[XmlRoot(ElementName = "chunk")]
public class Chunk
{
    [XmlAttribute("x")]
    public int X;

    [XmlAttribute("y")]
    public int Y;

    [XmlAttribute("width")]
    public int Width;

    [XmlAttribute("height")]
    public int Height;

    [XmlText]
    public string Content;
}
