using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Compiler;
using Newtonsoft.Json.Linq;
using System;

//using TWrite = MonoGame.ContentPipeline.UmbrellaToolKit.Model.AsepriteJson;
using TWrite = OgmoLevel;

namespace MonoGame.ContentPipeline.UmbrellaToolKit
{
    [ContentTypeWriter]
    public class OgmoTileMapWriter : ContentTypeWriter<TWrite>
    {
        protected override void Write(ContentWriter output, TWrite value)
        {
            output.Write((int)value.width);
            output.Write((int)value.height);
            output.Write((int)value.offsetX);
            output.Write((int)value.offsetY);

            // layers
            output.Write((int)value.layers.Count);
            for(var i = 0; i < value.layers.Count; i++)
            {
                output.Write((string)value.layers[i].name);
                output.Write((string)value.layers[i]._eid);
                output.Write((int)value.layers[i].offsetX);
                output.Write((int)value.layers[i].offsetY);
                output.Write((int)value.layers[i].gridCellWidth);
                output.Write((int)value.layers[i].gridCellHeight);
                output.Write((int)value.layers[i].gridCellsX);
                output.Write((int)value.layers[i].gridCellsY);

                // data2D
                output.Write((int)value.layers[i].data2D.Count);
                for (var x = 0; x < value.layers[i].data2D.Count; x++)
                {
                    output.Write((int)value.layers[i].data2D[x].Count);
                    for(var y = 0; x < value.layers[i].data2D[x].Count; y++)
                    {
                        output.Write((int)value.layers[i].data2D[x][y]);
                    }
                }

                // grid2D
                output.Write((int)value.layers[i].grid2D.Count);
                for (var x = 0; x < value.layers[i].grid2D.Count; x++)
                {
                    output.Write((int)value.layers[i].grid2D[x].Count);
                    for (var y = 0; x < value.layers[i].grid2D[x].Count; y++)
                    {
                        output.Write((int)value.layers[i].grid2D[x][y]);
                    }
                }

                // entities
                output.Write((int)value.layers[i].entities.Count);
                for(var e = 0; e < value.layers[i].entities.Count; e++)
                {
                    output.Write((string)value.layers[i].entities[e].name);
                    output.Write((string)value.layers[i].entities[e]._eid);
                    output.Write((int)value.layers[i].entities[e].x);
                    output.Write((int)value.layers[i].entities[e].y);
                    output.Write((int)value.layers[i].entities[e].originX);
                    output.Write((int)value.layers[i].entities[e].originY);
                    output.Write((int)value.layers[i].entities[e].width);
                    output.Write((int)value.layers[i].entities[e].height);
                    output.Write((string)value.layers[i].entities[e].values);

                    //nodes
                    output.Write((int)value.layers[i].entities[e].nodes.Count);
                    for (var n = 0; n < value.layers[i].entities[e].nodes.Count; n++)
                    {
                        output.Write((int)value.layers[i].entities[e].nodes[n].x);
                        output.Write((int)value.layers[i].entities[e].nodes[n].y);
                    }
                }
            }
        }

        public override string GetRuntimeReader(TargetPlatform targetPlatform)
        {
            return "UmbrellaToolKit.Ogmo.TileMapReader, UmbrellaToolKit";
        }
    }
}
