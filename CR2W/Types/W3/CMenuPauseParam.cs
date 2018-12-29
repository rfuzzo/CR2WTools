
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CMenuPauseParam : CObject, IMenuTimeParam
	{
		[REDProp("pauseType")]
		public EMenuPauseType PauseType { get; set; }

	}
}
