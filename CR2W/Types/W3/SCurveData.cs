
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SCurveData
	{
       


        [W3Type("Curve Values")]
        [W3ArrayFlags(142, 0)]
        public Array<SCurveDataEntry> CurveValues { get; set; } //space in var name

		[W3Type("value type")]
		public ECurveValueType ValueType { get; set; } //space in var name

        [W3Type("type")]
		public ECurveBaseType ScalarEditOrigin { get; set; }

		[W3Type("is looped")]
		public bool IsLooped { get; set; } //space in var name

    }
}
