
using System;


namespace CR2W.Types.W3
{
	public class CPopupPauseParam : CObject, IPopupTimeParam
	{
		[REDProp("pauseType")]
		public EPopupPauseType PauseType { get; set; }

	}
}
