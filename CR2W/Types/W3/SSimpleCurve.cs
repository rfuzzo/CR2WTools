
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SSimpleCurve
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
