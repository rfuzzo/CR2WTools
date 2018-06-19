
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CPopupPauseParam : CObject, IPopupTimeParam
	{
		[W3Type("pauseType")]
		public EPopupPauseType PauseType { get; set; }

	}
}
