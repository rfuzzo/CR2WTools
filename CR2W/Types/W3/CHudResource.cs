
using System;


namespace CR2W.Types.W3
{
	public class CHudResource : CResource, IGuiResource
	{
		[REDProp("resourceBlocks", 2, 0)]
		public Array<Ptr<CGraphBlock>> ResourceBlocks { get; set; }

		[REDProp("hudClass")]
		public CName HudClass { get; set; }

		[REDProp("hudFlashSwf")]
		public Soft<CSwfResource> HudFlashSwf { get; set; }

	}
}