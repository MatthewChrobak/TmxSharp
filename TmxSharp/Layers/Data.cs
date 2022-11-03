using System.Xml.Serialization;

namespace TmxSharp.Layers;

[XmlRoot(ElementName = "data")]
public class Data
{
    [XmlAttribute("encoding")]
    public string Encoding;

    [XmlElement("chunk", Type = typeof(Chunk))]
    public Chunk[] Chunks;
}
