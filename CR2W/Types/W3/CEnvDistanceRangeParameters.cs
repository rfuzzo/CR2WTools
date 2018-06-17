
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvDistanceRangeParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("distance")]
		public SSimpleCurve Distance { get; set; }

		[W3Type("range")]
		public SSimpleCurve Range { get; set; }

	}
}
