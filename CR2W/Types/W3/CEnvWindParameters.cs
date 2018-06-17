
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvWindParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("windStrengthOverride")]
		public SSimpleCurve WindStrengthOverride { get; set; }

		[W3Type("cloudsVelocityOverride")]
		public SSimpleCurve CloudsVelocityOverride { get; set; }

	}
}
