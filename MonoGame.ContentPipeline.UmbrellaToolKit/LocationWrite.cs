using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;

using TWrite = Location;

namespace MonoGame.ContentPipeline.UmbrellaToolKit
{
    [ContentTypeWriter]
    public class LocationWriter : ContentTypeWriter<TWrite>
    {
        protected override void Write(ContentWriter output, TWrite value)
        {
            // languages
            output.Write(value.languages.item.Length);
            for (int i = 0; i < value.languages.item.Length; i++) output.Write(value.languages.item[i]);

            // tags
            output.Write(value.tags.item.Length);
            for (int i = 0; i < value.tags.item.Length; i++) output.Write(value.tags.item[i]);

            // all Translations
            output.Write(value.tags.item.Length * value.languages.item.Length);
            for (int x = 0; x < value.translations_en.item.Length; x++) output.Write(value.translations_en.item[x]);
            for (int x = 0; x < value.translations_pt.item.Length; x++) output.Write(value.translations_pt.item[x]);
        }

        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            return "UmbrellaToolKit.Location, UmbrellaToolKit";
        }
    }
}
