
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvDistanceRangeParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("distance")]
		public SSimpleCurve Distance { get; set; }

		[REDProp("range")]
		public SSimpleCurve Range { get; set; }

	}
}
