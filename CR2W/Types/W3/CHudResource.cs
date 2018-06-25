
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CHudResource : CResource, IGuiResource
	{
		[REDProp("resourceBlocks")]
		public Array<Ptr<CGraphBlock>> ResourceBlocks { get; set; }

		[REDProp("hudClass")]
		public CName HudClass { get; set; }

		[REDProp("hudFlashSwf")]
		public Soft<CSwfResource> HudFlashSwf { get; set; }

	}
}