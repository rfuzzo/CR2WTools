
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SCurveData
	{
		[W3Type("Curve Values")]
		public Array<SCurveDataEntry> Curve Values { get; set; }

		[W3Type("value type")]
		public ECurveValueType Value type { get; set; }

		[W3Type("type")]
		public ECurveBaseType Type { get; set; }

		[W3Type("is looped")]
		public bool Is looped { get; set; }

	}
}
