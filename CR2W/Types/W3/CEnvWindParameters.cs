
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvWindParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("windStrengthOverride")]
		public SSimpleCurve WindStrengthOverride { get; set; }

		[REDProp("cloudsVelocityOverride")]
		public SSimpleCurve CloudsVelocityOverride { get; set; }

	}
}
