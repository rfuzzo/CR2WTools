
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CHudResource : CResource, IGuiResource
	{
		[W3Type("resourceBlocks")]
		public Array<Ptr<CGraphBlock>> ResourceBlocks { get; set; }

		[W3Type("hudClass")]
		public CName HudClass { get; set; }

		[W3Type("hudFlashSwf")]
		public Soft<CSwfResource> HudFlashSwf { get; set; }

	}
}