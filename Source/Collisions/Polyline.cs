using System.Xml.Serialization;

namespace TmxSharp.Collisions
{
    [XmlRoot(ElementName = "polyline")]
    public class Polyline
    {
        [XmlAttribute("points")]
        public string Points;
    }
}
