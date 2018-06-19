
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CFXTrackItem : CFXBase
	{
		[W3Type("timeBegin")]
		public float TimeBegin { get; set; }

		[W3Type("timeDuration")]
		public float TimeDuration { get; set; }

	}
}
