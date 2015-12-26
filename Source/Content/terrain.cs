using System.Xml.Serialization;

namespace TmxSharp.Content
{
    public class terrain
    {
        [XmlAttribute]
        public string name;

        [XmlAttribute]
        public int tile;

        [XmlArray]
        public property[] properties;
    }
}
