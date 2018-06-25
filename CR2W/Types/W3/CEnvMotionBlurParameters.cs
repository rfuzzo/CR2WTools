
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvMotionBlurParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("strength")]
		public SSimpleCurve Strength { get; set; }

	}
}
