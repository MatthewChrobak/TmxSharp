using System.Xml.Serialization;
using TmxSharp.Collision;
using TmxSharp.Content.Animation;

namespace TmxSharp
{
    public class tile
    {
        [XmlAttribute]
        public int gid;

        [XmlAttribute]
        public int id;

        [XmlAttribute]
        public string terrain;

        [XmlElement]
        public objectgroup[] objectgroup;

        [XmlArray]
        public frame[] animation;

        [XmlArray]
        public property[] properties;
    }
}
