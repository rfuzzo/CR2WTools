
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CGuiConfigResource : CResource
	{
		[W3Type("huds")]
        [W3ArrayFlags(2, 0)]
        public Array<SHudDescription> Huds { get; set; }

		[W3Type("menus")]
        [W3ArrayFlags(2, 0)]
        public Array<SMenuDescription> Menus { get; set; }

		[W3Type("popups")]
        [W3ArrayFlags(2, 0)]
        public Array<SPopupDescription> Popups { get; set; }

		[W3Type("scene")]
		public SGuiSceneDescription Scene { get; set; }

	}
}