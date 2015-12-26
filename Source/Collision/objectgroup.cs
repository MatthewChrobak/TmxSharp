using System.Xml.Serialization;

namespace TmxSharp.Collision
{
    public class objectgroup
    {
        [XmlAttribute]
        public string name;

        [XmlAttribute]
        public string draworder;

        [XmlElement]
        public @object[] @object;

        [XmlArray]
        public property[] properties;
    }
}
