using System.Xml.Serialization;

namespace TmxSharp.Layers
{
    [XmlRoot(ElementName = "tile")]
    public class LayerTile
    {
        [XmlAttribute("gid")]
        public int GID;
    }
}
