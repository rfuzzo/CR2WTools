
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CMenuPauseParam : CObject, IMenuTimeParam
	{
		[W3Type("pauseType")]
		public EMenuPauseType PauseType { get; set; }

	}
}
