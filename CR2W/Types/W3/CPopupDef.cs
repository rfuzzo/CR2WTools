
using System;


namespace CR2W.Types.W3
{
	public class CPopupDef : CObject
	{
		[REDProp("timeParam")]
		public Ptr<IPopupTimeParam> TimeParam { get; set; }

	}
}
