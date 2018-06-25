
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvShadowsParameters
	{
		[REDProp("activatedAutoHide")]
		public bool ActivatedAutoHide { get; set; }

		[REDProp("autoHideBoxSizeMin")]
		public SSimpleCurve AutoHideBoxSizeMin { get; set; }

		[REDProp("autoHideBoxSizeMax")]
		public SSimpleCurve AutoHideBoxSizeMax { get; set; }

		[REDProp("autoHideBoxCompMaxX")]
		public SSimpleCurve AutoHideBoxCompMaxX { get; set; }

		[REDProp("autoHideBoxCompMaxY")]
		public SSimpleCurve AutoHideBoxCompMaxY { get; set; }

		[REDProp("autoHideBoxCompMaxZ")]
		public SSimpleCurve AutoHideBoxCompMaxZ { get; set; }

		[REDProp("autoHideDistScale")]
		public SSimpleCurve AutoHideDistScale { get; set; }

	}
}
