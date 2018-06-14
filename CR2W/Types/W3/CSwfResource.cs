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
        public string linkageName { get; set; }
        public Array<SSwfFontDesc> fonts { get; set; }
        public Array<Handle<CSwfTexture>> textures { get; set; }
        public SSwfHeaderInfo header { get; set; }
        public string imageImportOptions { get; set; }

        public byte[] data { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);

            /* - ToDo 
             *   parse the remaining bytes that is the swf resource.
             */
        }
    }
}