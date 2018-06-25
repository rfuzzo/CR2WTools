
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CMenuResource : CResource, IGuiResource
	{
		[REDProp("resourceBlocks")]
		public Array<Ptr<CGraphBlock>> ResourceBlocks { get; set; }

		[REDProp("menuClass")]
		public CName MenuClass { get; set; }

		[REDProp("menuFlashSwf")]
		public Soft<CSwfResource> MenuFlashSwf { get; set; }

		[REDProp("layer")]
		public UInt32 Layer { get; set; }

		[REDProp("menuDef")]
		public Ptr<CMenuDef> MenuDef { get; set; }

	}
}
