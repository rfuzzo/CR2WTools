
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CHudResource : CResource, IGuiResource
	{
		[REDProp("resourceBlocks", 2, 0)]
		public Array<Ptr<CGraphBlock>> ResourceBlocks { get; set; }

		[REDProp("hudClass")]
		public CName HudClass { get; set; }

		[REDProp("hudFlashSwf")]
		public Soft<CSwfResource> HudFlashSwf { get; set; }

	}
}