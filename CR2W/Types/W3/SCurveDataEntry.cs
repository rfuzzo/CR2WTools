
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SCurveDataEntry
	{
		[W3Type("me")]
		public float Me { get; set; }

		[W3Type("ntrolPoint")]
		public Vector NtrolPoint { get; set; }

		[W3Type("lue")]
		public float Lue { get; set; }

		[W3Type("rveTypeL")]
		public UInt16 RveTypeL { get; set; }

		[W3Type("rveTypeR")]
		public UInt16 RveTypeR { get; set; }

	}
}
