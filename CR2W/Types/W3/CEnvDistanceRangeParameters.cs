
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvDistanceRangeParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("distance")]
		public SSimpleCurve Distance { get; set; }

		[REDProp("range")]
		public SSimpleCurve Range { get; set; }

	}
}
