
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CPopupDef : CObject
	{
		[REDProp("timeParam")]
		public Ptr<IPopupTimeParam> TimeParam { get; set; }

	}
}
