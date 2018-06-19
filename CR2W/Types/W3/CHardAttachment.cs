
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CHardAttachment : IAttachment
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

		//[W3Type("attachmentFlags")]
		//public EHardAttachmentFlags AttachmentFlags { get; set; } //not in RTTI

		[W3Type("parentSlot")]
		public Ptr<ISlot> ParentSlot { get; set; }

	}
}
