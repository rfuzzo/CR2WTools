using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CR2W.IO;


namespace CR2W.Types.W3
{
    public class CSwfResource : CResource
    {
        [REDProp("linkageName")]
        public string LinkageName { get; set; }

        [REDProp("fonts", 2, 0)]
        public Array<SSwfFontDesc> Fonts { get; set; }

        [REDProp("textures", 2, 0)]
        public Array<Handle<CSwfTexture>> Textures { get; set; }

        [REDProp("header")]
        public SSwfHeaderInfo Header { get; set; }

        [REDProp("imageImportOptions")]
        public string ImageImportOptions { get; set; }

        public byte[] Data { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);
            var dataSize = br.ReadInt32();
            Data = br.ReadBytes(dataSize);
        }
    }
}