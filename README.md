# TmxSharp
A C# library that acts merely as a data structure for .tmx Tiled map files.
It does not provide out-of-the-box serialization. It must be implemented on your own accord.



# Sample Deserialization Code

            var xml = new XmlSerializer(typeof(map));
            var stream = new FileStream(filepath, FileMode.Open);
            var instance = (map)xml.Deserialize(stream);
            stream.Close();
            
*remember to declare usage of the TmxSharp namespace*
