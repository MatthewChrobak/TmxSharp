using System.Xml.Serialization;

namespace TmxSharp.Content.Animation
{
    public class frame
    {
        [XmlAttribute]
        public int tileid;

        [XmlAttribute]
        public int duration;
    }
}
