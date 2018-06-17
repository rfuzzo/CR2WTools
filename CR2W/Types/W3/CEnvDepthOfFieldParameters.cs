
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvDepthOfFieldParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("nearBlurDist")]
		public SSimpleCurve NearBlurDist { get; set; }

		[W3Type("nearFocusDist")]
		public SSimpleCurve NearFocusDist { get; set; }

		[W3Type("farFocusDist")]
		public SSimpleCurve FarFocusDist { get; set; }

		[W3Type("farBlurDist")]
		public SSimpleCurve FarBlurDist { get; set; }

		[W3Type("intensity")]
		public SSimpleCurve Intensity { get; set; }

		[W3Type("activatedSkyThreshold")]
		public bool ActivatedSkyThreshold { get; set; }

		[W3Type("skyThreshold")]
		public float SkyThreshold { get; set; }

		[W3Type("activatedSkyRange")]
		public bool ActivatedSkyRange { get; set; }

		[W3Type("skyRange")]
		public float SkyRange { get; set; }

	}
}
