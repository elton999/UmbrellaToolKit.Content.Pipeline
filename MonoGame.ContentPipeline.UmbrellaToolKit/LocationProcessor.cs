using System;
using Microsoft.Xna.Framework.Content.Pipeline;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Text;
// TODO: replace these with the processor input and output types.
using TInput = Location;
using TOutput = Location;

namespace MonoGame.ContentPipeline.UmbrellaToolKit
{
    /// <summary>
    /// This class will be instantiated by the XNA Framework Content Pipeline
    /// to apply custom processing to content data, converting an object of
    /// type TInput to TOutput. The input and output types may be the same if
    /// the processor wishes to alter data without changing its type.
    ///
    /// This should be part of a Content Pipeline Extension Library project.
    ///
    /// TODO: change the ContentProcessor attribute to specify the correct
    /// display name for this processor.
    /// </summary>
    [ContentProcessor(DisplayName = "Location Processor")]
    public class LocationProcessor : ContentProcessor<TInput, TOutput>
    {
        public override TOutput Process(TInput input, ContentProcessorContext context)
        {
            return input;
        }
    }
}