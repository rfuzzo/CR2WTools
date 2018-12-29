
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvMotionBlurParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("strength")]
		public SSimpleCurve Strength { get; set; }

	}
}
