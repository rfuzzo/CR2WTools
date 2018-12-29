
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvParametricBalanceParameters
	{
		[REDProp("saturation")]
		public SSimpleCurve Saturation { get; set; }

		[REDProp("color")]
		public SSimpleCurve Color { get; set; }

	}
}
