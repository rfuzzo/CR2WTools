
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvPaintEffectParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("amount")]
		public SSimpleCurve Amount { get; set; }

	}
}
