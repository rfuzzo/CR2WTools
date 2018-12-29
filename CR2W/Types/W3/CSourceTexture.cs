using System;
using System.ComponentModel;
using System.Text;
using CR2W.IO;

namespace CR2W.Types.W3
{
    [TypeConverter(typeof(ExpandableObjectConverter))]public class CSourceTexture : CResource
    {
        [REDProp("width")]
        public UInt32 Width { get; set; }

        [REDProp("height")]
        public UInt32 Height { get; set; }

        [REDProp("pitch")]
        public UInt32 Pitch { get; set; }

        [REDProp("format")]
        public ETextureRawFormat Format { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            var end = br.BaseStream.Position + size;

            base.ParseBytes(br, size);

        }
    }
}
