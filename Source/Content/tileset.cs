using System.Xml.Serialization;

namespace TmxSharp.Content
{
    public class tileset
    {
        [XmlAttribute]
        public int firstgid;

        [XmlAttribute]
        public string name;

        [XmlAttribute]
        public int tilewidth;

        [XmlAttribute]
        public int tileheight;

        [XmlAttribute]
        public int tilecount;

        [XmlElement]
        public image image;

        [XmlElement]
        public tile[] tile;

        [XmlArray]
        public property[] properties;

        [XmlArray]
        public terrain[] terraintypes;
    }
}
