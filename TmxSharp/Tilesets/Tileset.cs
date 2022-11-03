using System.Xml.Serialization;

namespace TmxSharp.Tilesets
{
    [XmlRoot(ElementName = "tileset")]
    public class Tileset
    {
        [XmlAttribute("firstgid")]
        public int FirstGID;

        [XmlAttribute("source")]
        public string Source;

        /* Are these still used?
        [XmlElement("tile", Type = typeof(TilesetTile))]
        public TilesetTile[] Tile;

        [XmlArray("properties")]
        [XmlArrayItem(ElementName = "property")]
        public Property[] Properties;

        [XmlArray("terraintypes")]
        [XmlArrayItem(ElementName = "terrain")]
        public Terrain[] TerrainTypes;
        */
    }
}
