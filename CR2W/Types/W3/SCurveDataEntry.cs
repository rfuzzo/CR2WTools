
using System;


namespace CR2W.Types.W3
{
    [REDClass]
    public struct SCurveDataEntry
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
