
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvMotionBlurParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("strength")]
		public SSimpleCurve Strength { get; set; }

	}
}
