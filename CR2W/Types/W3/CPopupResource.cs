
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CPopupResource : CResource, IGuiResource
	{
		[W3Type("resourceBlocks")]
        [W3ArrayFlags(2, 0)]
        public Array<Ptr<CGraphBlock>> ResourceBlocks { get; set; }

		[W3Type("popupClass")]
		public CName PopupClass { get; set; }

		[W3Type("popupFlashSwf")]
		public Soft<CSwfResource> PopupFlashSwf { get; set; }

		[W3Type("layer")]
		public UInt32 Layer { get; set; }

		[W3Type("popupDef")]
		public Ptr<CPopupDef> PopupDef { get; set; }

	}
}
