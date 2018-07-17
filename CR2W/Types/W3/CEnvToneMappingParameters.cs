
using System;


namespace CR2W.Types.W3
{
	public class CEnvToneMappingParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("skyLuminanceCustomValue")]
		public SSimpleCurve SkyLuminanceCustomValue { get; set; }

		[REDProp("skyLuminanceCustomAmount")]
		public SSimpleCurve SkyLuminanceCustomAmount { get; set; }

		[REDProp("luminanceLimitShape")]
		public SSimpleCurve LuminanceLimitShape { get; set; }

		[REDProp("luminanceLimitMin")]
		public SSimpleCurve LuminanceLimitMin { get; set; }

		[REDProp("luminanceLimitMax")]
		public SSimpleCurve LuminanceLimitMax { get; set; }

		[REDProp("rejectThreshold")]
		public SSimpleCurve RejectThreshold { get; set; }

		[REDProp("rejectSmoothExtent")]
		public SSimpleCurve RejectSmoothExtent { get; set; }

		[REDProp("newToneMapCurveParameters")]
		public CEnvToneMappingCurveParameters NewToneMapCurveParameters { get; set; }

		[REDProp("newToneMapWhitepoint")]
		public SSimpleCurve NewToneMapWhitepoint { get; set; }

		[REDProp("newToneMapPostScale")]
		public SSimpleCurve NewToneMapPostScale { get; set; }

		[REDProp("exposureScale")]
		public SSimpleCurve ExposureScale { get; set; }

		[REDProp("postScale")]
		public SSimpleCurve PostScale { get; set; }

	}
}
