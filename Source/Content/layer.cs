using System.Xml.Serialization;

namespace TmxSharp.Content
{
    public class layer
    {
        [XmlAttribute]
        public string name;

        [XmlAttribute]
        public int width;

        [XmlAttribute]
        public int height;

        [XmlArray]
        public tile[] data;

        [XmlArray]
        public property[] properties;
    }
}
