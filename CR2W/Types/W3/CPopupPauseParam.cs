
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CPopupPauseParam : CObject, IPopupTimeParam
	{
		[REDProp("pauseType")]
		public EPopupPauseType PauseType { get; set; }

	}
}
