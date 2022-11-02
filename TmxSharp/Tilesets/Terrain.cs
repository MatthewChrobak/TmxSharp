using System.Xml.Serialization;

namespace TmxSharp.Tilesets
{
    [XmlRoot(ElementName = "terrain")]
    public class Terrain
    {
        [XmlAttribute("name")]
        public string Name;

        [XmlAttribute("tile")]
        public int Tile;

        [XmlArray("properties")]
        [XmlArrayItem(ElementName = "property")]
        public Property[] Properties;
    }
}
