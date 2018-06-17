
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvPaintEffectParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("amount")]
		public SSimpleCurve Amount { get; set; }

	}
}
