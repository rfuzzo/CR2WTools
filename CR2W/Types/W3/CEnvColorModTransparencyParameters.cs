
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvColorModTransparencyParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("commonFarDist")]
		public SSimpleCurve CommonFarDist { get; set; }

		[W3Type("filterNearColor")]
		public SSimpleCurve FilterNearColor { get; set; }

		[W3Type("filterFarColor")]
		public SSimpleCurve FilterFarColor { get; set; }

		[W3Type("contrastNearStrength")]
		public SSimpleCurve ContrastNearStrength { get; set; }

		[W3Type("contrastFarStrength")]
		public SSimpleCurve ContrastFarStrength { get; set; }

		[W3Type("autoHideCustom0")]
		public CEnvDistanceRangeParameters AutoHideCustom0 { get; set; }

		[W3Type("autoHideCustom1")]
		public CEnvDistanceRangeParameters AutoHideCustom1 { get; set; }

		[W3Type("autoHideCustom2")]
		public CEnvDistanceRangeParameters AutoHideCustom2 { get; set; }

		[W3Type("autoHideCustom3")]
		public CEnvDistanceRangeParameters AutoHideCustom3 { get; set; }

	}
}
