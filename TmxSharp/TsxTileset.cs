using System.Xml.Serialization;
using TmxSharp.Images;

namespace TmxSharp;

[XmlRoot(ElementName = "tileset")]
public class TsxTileset
{
    [XmlElement("version")]
    public string Version;

    [XmlElement("tiledversion")]
    public string TiledVersion;

    [XmlAttribute("name")]
    public string Name;

    [XmlAttribute("tilewidth")]
    public int TileWidth;

    [XmlAttribute("tileheight")]
    public int TileHeight;

    [XmlAttribute("tilecount")]
    public int TileCount;

    [XmlElement("image")]
    public Image Image;

    public static TsxTileset Load(string path) {
        // Deserialize it, and return the TmxMap instance.
        var xml = new XmlSerializer(typeof(TsxTileset));
        using (var stream = new FileStream(path, FileMode.Open)) {
            var instance = (TsxTileset)xml.Deserialize(stream);
            stream.Close();
            return instance;
        }
    }
}
