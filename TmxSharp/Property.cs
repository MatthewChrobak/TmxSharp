using System.Xml.Serialization;

namespace TmxSharp
{
    [XmlRoot(ElementName = "property")]
    public class Property
    {
        [XmlAttribute("name")]
        public string Name;

        [XmlAttribute("value")]
        public string Value;
    }
}
