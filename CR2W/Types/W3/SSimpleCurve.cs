
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SSimpleCurve
	{
		[W3Type("CurveType")]
		public ESimpleCurveType CurveType { get; set; }

		[W3Type("ScalarEditScale")]
		public float ScalarEditScale { get; set; }

		[W3Type("ScalarEditOrigin")]
		public float ScalarEditOrigin { get; set; }

		[W3Type("dataCurveValues")]
        [W3ArrayFlags(142, 0)]
		public Array<SCurveDataEntry> DataCurveValues { get; set; }

		[W3Type("dataBaseType")]
		public ECurveBaseType DataBaseType { get; set; }

	}
}
