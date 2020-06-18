using System;
using System.IO;
using System.Xml.Serialization;
using Microsoft.Xna.Framework.Content.Pipeline;

using TInput = ConfigMap;
namespace MonoGame.ContentPipeline.UmbrellaToolKit
{
    [ContentImporter(".tmx", DisplayName = "Tile Map Importer  - UmbrellaToolKit", DefaultProcessor = "TileMapProcessor")]
    public class TileMapImporter : ContentImporter<TInput>
    {
        public override TInput Import(string filename, ContentImporterContext context)
        {
            var serializer = new XmlSerializer(typeof(ConfigMap));
            using (StreamReader stream = new StreamReader(filename))
            {
                return (ConfigMap)serializer.Deserialize(stream);
            }
        }

    }

}