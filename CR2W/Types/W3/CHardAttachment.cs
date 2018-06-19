using System;
using System.IO;
using System.Drawing;
using CR2W.IO;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
    public class CHardAttachment : CResource
    {
       

        [W3Type("parent")]
        public Ptr<CNode> Parent { get; set; }

        [W3Type("child")]
        public Ptr<CNode> Child { get; set; }

        [W3Type("isBroken")]
        public bool IsBroken { get; set; }

        [W3Type("relativeTransform")]
        public EngineTransform RelativeTransform { get; set; }

        [W3Type("parentSlotName")]
        public CName ParentSlotName { get; set; }

        /*[W3Type("attachmentFlags")]
        public EHardAttachmentFlags AttachmentFlags { get; set; }*/ //not in enums?

        [W3Type("parentSlot")]
        public Ptr<ISlot> ParentSlot { get; set; }

        public override void ParseBytes(CR2WBinaryReader br, uint size)
        {
            base.ParseBytes(br, size);
        }
    }
}
 