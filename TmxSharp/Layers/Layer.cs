﻿using System.Xml.Serialization;

namespace TmxSharp.Layers
{
    [XmlRoot(ElementName = "layer")]
    public class Layer
    {
        [XmlAttribute("name")]
        public string Name;

        [XmlAttribute("width")]
        public int Width;

        [XmlAttribute("height")]
        public int Height;

        [XmlAttribute("opacity")]
        public float Opacity;

        [XmlAttribute("visible")]
        public byte Visible = 1;

        [XmlAttribute("offsetx")]
        public int OffsetX;

        [XmlAttribute("offsety")]
        public int OffsetY;

        [XmlElement("data")]
        public Data Data;

        [XmlArray("properties")]
        [XmlArrayItem(ElementName = "property")]
        public Property[] Properties;
    }
}
