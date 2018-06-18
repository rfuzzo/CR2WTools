
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CGuiConfigResource : CResource
	{
		[W3Type("huds")]
		public Array<SHudDescription> Huds { get; set; }

		[W3Type("menus")]
		public Array<SMenuDescription> Menus { get; set; }

		[W3Type("popups")]
		public Array<SPopupDescription> Popups { get; set; }

		[W3Type("scene")]
		public SGuiSceneDescription Scene { get; set; }

	}
}