using System.IO;
using System.Xml.Serialization;
using TmxSharp.Collisions;
using TmxSharp.Images;
using TmxSharp.Layers;
using TmxSharp.Tilesets;

namespace TmxSharp
{
    [XmlRoot(ElementName = "map")]
    public class TmxMap
    {
        [XmlAttribute("version")]
        public string Version;

        [XmlAttribute("orientation")]
        public string Orientation;

        [XmlAttribute("renderorder")]
        public string RenderOrder;

        [XmlAttribute("width")]
        public int Width;

        [XmlAttribute("height")]
        public int Height;

        [XmlAttribute("backgroundcolor")]
        public string BackgroundColor;

        [XmlAttribute("tilewidth")]
        public int TileWidth;

        [XmlAttribute("tileheight")]
        public int TileHeight;

        [XmlAttribute("nextobjectid")]
        public int NextObjectID;

        [XmlElement("tileset")]
        public Tileset[] Tileset;

        [XmlElement("layer")]
        public Layer[] Layer;

        [XmlElement("objectgroup")]
        public CollisionObjectGroup[] ObjectGroup;

        [XmlElement("imagelayer")]
        public ImageLayer ImageLayer;

        [XmlArray("properties")]
        [XmlArrayItem(ElementName = "property")]
        public Property[] Properties;

        public void Save(string path) {
            var xml = new XmlSerializer(typeof(TmxMap));
            using (var stream = new StreamWriter(path)) {
                xml.Serialize(stream, this);
                stream.Close();
            }
        }

        public static TmxMap Load(string path) {
            // Make sure the file exists.
            if (File.Exists(path)) {
                // Make sure it's a .tmx file.
                if (path.EndsWith(".tmx")) {

                    // Deserialize it, and return the TmxMap instance.
                    var xml = new XmlSerializer(typeof(TmxMap));
                    using (var stream = new FileStream(path, FileMode.Open)) {
                        var instance = (TmxMap)xml.Deserialize(stream);
                        stream.Close();
                        return instance;
                    }
                } else {
                    throw new System.IO.IOException("Invalid file format - .tmx Expected");
                }
            } else {
                throw new System.IO.FileNotFoundException(path);
            }
        }
    }
}
