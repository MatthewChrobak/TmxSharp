using System.Xml.Serialization;

namespace TmxSharp
{
    public class property
    {
        [XmlAttribute]
        public string name;

        [XmlAttribute]
        public string value;
    }
}
