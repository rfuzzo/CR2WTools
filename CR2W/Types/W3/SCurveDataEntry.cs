
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SCurveDataEntry
	{
		[REDProp("me")]
		public float Me { get; set; }

		[REDProp("ntrolPoint")]
		public Vector NtrolPoint { get; set; }

		[REDProp("lue")]
		public float Lue { get; set; }

		[REDProp("rveTypeL")]
		public UInt16 RveTypeL { get; set; }

		[REDProp("rveTypeR")]
		public UInt16 RveTypeR { get; set; }

	}
}
