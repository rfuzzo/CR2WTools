
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvShadowsParameters
	{
		[W3Type("activatedAutoHide")]
		public bool ActivatedAutoHide { get; set; }

		[W3Type("autoHideBoxSizeMin")]
		public SSimpleCurve AutoHideBoxSizeMin { get; set; }

		[W3Type("autoHideBoxSizeMax")]
		public SSimpleCurve AutoHideBoxSizeMax { get; set; }

		[W3Type("autoHideBoxCompMaxX")]
		public SSimpleCurve AutoHideBoxCompMaxX { get; set; }

		[W3Type("autoHideBoxCompMaxY")]
		public SSimpleCurve AutoHideBoxCompMaxY { get; set; }

		[W3Type("autoHideBoxCompMaxZ")]
		public SSimpleCurve AutoHideBoxCompMaxZ { get; set; }

		[W3Type("autoHideDistScale")]
		public SSimpleCurve AutoHideDistScale { get; set; }

	}
}
