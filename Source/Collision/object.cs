using System.Xml.Serialization;

namespace TmxSharp.Collision
{
    public class @object
    {
        [XmlAttribute]
        public int id;

        [XmlAttribute]
        public string name;

        [XmlAttribute]
        public string type;

        [XmlAttribute]
        public float x;

        [XmlAttribute]
        public float y;

        [XmlAttribute]
        public float width;

        [XmlAttribute]
        public float height;

        [XmlAttribute]
        public float rotation;

        [XmlArray]
        public property[] properties;

        [XmlElement]
        public ellipse ellipse;

        [XmlElement]
        public polyline polyline;
    }
}
