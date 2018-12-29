
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvWindParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("windStrengthOverride")]
		public SSimpleCurve WindStrengthOverride { get; set; }

		[REDProp("cloudsVelocityOverride")]
		public SSimpleCurve CloudsVelocityOverride { get; set; }

	}
}
