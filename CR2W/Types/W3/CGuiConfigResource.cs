
using System;


namespace CR2W.Types.W3
{
	public class CGuiConfigResource : CResource
	{
		[REDProp("huds", 2, 0)]
		public Array<SHudDescription> Huds { get; set; }

		[REDProp("menus", 2, 0)]
		public Array<SMenuDescription> Menus { get; set; }

		[REDProp("popups", 2, 0)]
		public Array<SPopupDescription> Popups { get; set; }

		[REDProp("scene")]
		public SGuiSceneDescription Scene { get; set; }

	}
}