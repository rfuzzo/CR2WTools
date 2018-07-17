using System;

namespace CR2W.Types.W3
{
    [REDClass]
    public struct SSimpleCurve
    {
		[REDProp("CurveType")]
		public ESimpleCurveType CurveType { get; set; }

		[REDProp("ScalarEditScale")]
		public float ScalarEditScale { get; set; }

		[REDProp("ScalarEditOrigin")]
		public float ScalarEditOrigin { get; set; }

		[REDProp("dataCurveValues", 142, 0)]
		public Array<SCurveDataEntry> DataCurveValues { get; set; }

		[REDProp("dataBaseType")]
		public ECurveBaseType DataBaseType { get; set; }

	}
}
