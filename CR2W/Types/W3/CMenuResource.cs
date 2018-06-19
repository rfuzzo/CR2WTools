
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CMenuResource : CResource, IGuiResource
	{
		[W3Type("resourceBlocks")]
        [W3ArrayFlags(2, 0)]
        public Array<Ptr<CGraphBlock>> ResourceBlocks { get; set; }

		[W3Type("menuClass")]
		public CName MenuClass { get; set; }

		[W3Type("menuFlashSwf")]
		public Soft<CSwfResource> MenuFlashSwf { get; set; }

		[W3Type("layer")]
		public UInt32 Layer { get; set; }

		[W3Type("menuDef")]
		public Ptr<CMenuDef> MenuDef { get; set; }

	}
}
