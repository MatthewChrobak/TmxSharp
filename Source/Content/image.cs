using System.Xml.Serialization;

namespace TmxSharp.Content
{
    public class image
    {
        [XmlAttribute]
        public string source;

        [XmlAttribute]
        public string trans;

        [XmlAttribute]
        public int width;

        [XmlAttribute]
        public int height;
    }
}
