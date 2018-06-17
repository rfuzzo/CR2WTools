
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvToneMappingParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("skyLuminanceCustomValue")]
		public SSimpleCurve SkyLuminanceCustomValue { get; set; }

		[W3Type("skyLuminanceCustomAmount")]
		public SSimpleCurve SkyLuminanceCustomAmount { get; set; }

		[W3Type("luminanceLimitShape")]
		public SSimpleCurve LuminanceLimitShape { get; set; }

		[W3Type("luminanceLimitMin")]
		public SSimpleCurve LuminanceLimitMin { get; set; }

		[W3Type("luminanceLimitMax")]
		public SSimpleCurve LuminanceLimitMax { get; set; }

		[W3Type("rejectThreshold")]
		public SSimpleCurve RejectThreshold { get; set; }

		[W3Type("rejectSmoothExtent")]
		public SSimpleCurve RejectSmoothExtent { get; set; }

		[W3Type("newToneMapCurveParameters")]
		public CEnvToneMappingCurveParameters NewToneMapCurveParameters { get; set; }

		[W3Type("newToneMapWhitepoint")]
		public SSimpleCurve NewToneMapWhitepoint { get; set; }

		[W3Type("newToneMapPostScale")]
		public SSimpleCurve NewToneMapPostScale { get; set; }

		[W3Type("exposureScale")]
		public SSimpleCurve ExposureScale { get; set; }

		[W3Type("postScale")]
		public SSimpleCurve PostScale { get; set; }

	}
}
