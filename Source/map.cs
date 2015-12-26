using System.Xml.Serialization;
using TmxSharp.Collision;
using TmxSharp.Content;

namespace TmxSharp
{
    public class map
    {
        [XmlAttribute]
        public string version;

        [XmlAttribute]
        public string orientation;

        [XmlAttribute]
        public string renderorder;

        [XmlAttribute]
        public int width;

        [XmlAttribute]
        public int height;

        [XmlAttribute]
        public int tilewidth;

        [XmlAttribute]
        public int tileheight;

        [XmlAttribute]
        public int nextobjectid;

        [XmlElement]
        public tileset[] tileset;

        [XmlElement]
        public layer[] layer;

        [XmlElement]
        public objectgroup[] objectgroup;

        [XmlArray]
        public property[] properties;
    }
}
