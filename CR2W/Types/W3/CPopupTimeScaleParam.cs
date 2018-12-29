
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CPopupTimeScaleParam : CObject, IPopupTimeParam
	{
		[REDProp("timeScale")]
		public float TimeScale { get; set; }

		[REDProp("multiplicative")]
		public bool Multiplicative { get; set; }

	}
}
