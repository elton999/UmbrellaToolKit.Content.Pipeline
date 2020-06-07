using System;
using System.IO;
using System.Xml.Serialization;
using Microsoft.Xna.Framework.Content.Pipeline;

using TInput = ConfigTileSet;
namespace MonoGame.ContentPipeline.UmbrellaToolKit
{
    /// <summary>
    /// This class will be instantiated by the XNA Framework Content Pipeline
    /// to import a file from disk into the specified type, TImport.
    ///
    /// This should be part of a Content Pipeline Extension Library project.
    ///
    /// TODO: change the ContentImporter attribute to specify the correct file
    /// extension, display name, and default processor for this importer.
    /// </summary>

    [ContentImporter(".tsx", DisplayName = "Tileset Importer  - UmbrellaToolKit", DefaultProcessor = "TileSetProcessor")]
    public class TileSetImporter : ContentImporter<TInput>
    {
        public override TInput Import(string filename, ContentImporterContext context)
        {
            var serializer = new XmlSerializer(typeof(ConfigTileSet));
            using (StreamReader stream = new StreamReader(filename))
            {
                return (ConfigTileSet)serializer.Deserialize(stream);
            }
        }

    }

}