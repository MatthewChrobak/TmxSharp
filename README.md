# TmxSharp
A .NET C# library providing the tools necessary to serialize, deserialize, and explore the components of a Tiled .TMX map file.



# I/O Examples
            // Deserialization
            var map = TmxMap.Load(FilePath);

            // Serialization
            map.Save(FilePath);
            
*remember to declare usage of the TmxSharp namespace*
