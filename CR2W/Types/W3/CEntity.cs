using System;
using System.IO;
using System.Drawing;
using CR2W.IO;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
    public class CEntity : CResource
    {
        [W3Type("tags")]
        public TagList Tags { get; set; }

        [W3Type("transform")]
        public EngineTransform Transform { get; set; }

        [W3Type("transformParent")]
        public Ptr<CHardAttachment> TransformParent { get; set; }

        [W3Type("guid")]
        public CGUID Guid { get; set; }

        [W3Type("components")]
        [W3ArrayFlags(2, 0)]
        public Array<Ptr<CComponent>> Components { get; set; }

        [W3Type("template")]
        public Handle<CEntityTemplate> _Template { get; set; } //inherited name Template

        [W3Type("streamingDataBuffer")]
        public SharedDataBuffer StreamingDataBuffer { get; set; }

        [W3Type("streamingDistance")]
        public byte StreamingDistance { get; set; } //uint8

        [W3Type("entityStaticFlags")]
        public EEntityStaticFlags EntityStaticFlags { get; set; }

        [W3Type("autoPlayEffectName")]
        public CName AutoPlayEffectName { get; set; }

        [W3Type("entityFlags")]
        public byte EntityFlags { get; set; } //uint8

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);
        }
    }
}
 