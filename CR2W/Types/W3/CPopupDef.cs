
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CPopupDef : CObject
	{
		[REDProp("timeParam")]
		public Ptr<IPopupTimeParam> TimeParam { get; set; }

	}
}
