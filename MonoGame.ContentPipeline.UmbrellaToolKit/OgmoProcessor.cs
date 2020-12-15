using System;
using Microsoft.Xna.Framework.Content.Pipeline;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TInput = System.String;
using TOutput = OgmoModel;

namespace MonoGame.ContentPipeline.UmbrellaToolKit
{
    [ContentProcessor(DisplayName = "Ogmo Processor - UmbrellaToolKit")]
    public class OgmoProcessor : ContentProcessor<TInput, TOutput>
    {
        public override TOutput Process(TInput input, ContentProcessorContext context)
        {
            return JsonConvert.DeserializeObject<OgmoModel>(input);
        }
    }
}
