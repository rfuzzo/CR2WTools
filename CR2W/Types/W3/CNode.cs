using System;
using System.IO;
using System.Drawing;
using CR2W.IO;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
    public class CNode : CResource
    {
        

        [W3Type("tags")]
        public TagList Tags { get; set; }

        [W3Type("transform")]
        public EngineTransform Transform { get; set; }

        [W3Type("transformParent")]
        public Ptr<CHardAttachment> TransformParent { get; set; }

        [W3Type("guid")]
        public CGUID Guid { get; set; }

        

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);
        }
    }
}
 