
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CPopupResource : CResource, IGuiResource
	{
		[REDProp("resourceBlocks")]
		public Array<Ptr<CGraphBlock>> ResourceBlocks { get; set; }

		[REDProp("popupClass")]
		public CName PopupClass { get; set; }

		[REDProp("popupFlashSwf")]
		public Soft<CSwfResource> PopupFlashSwf { get; set; }

		[REDProp("layer")]
		public UInt32 Layer { get; set; }

		[REDProp("popupDef")]
		public Ptr<CPopupDef> PopupDef { get; set; }

	}
}
