
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SCurveEaseParam
	{
		[W3Type("easeIn")]
		public float EaseIn { get; set; }

		[W3Type("easeOut")]
		public float EaseOut { get; set; }

	}
}
