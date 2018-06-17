
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvSunAndMoonParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("sunSize")]
		public SSimpleCurve SunSize { get; set; }

		[W3Type("sunColor")]
		public SSimpleCurve SunColor { get; set; }

		[W3Type("sunFlareSize")]
		public SSimpleCurve SunFlareSize { get; set; }

		[W3Type("sunFlareColor")]
		public CEnvFlareColorParameters SunFlareColor { get; set; }

		[W3Type("moonSize")]
		public SSimpleCurve MoonSize { get; set; }

		[W3Type("moonColor")]
		public SSimpleCurve MoonColor { get; set; }

		[W3Type("moonFlareSize")]
		public SSimpleCurve MoonFlareSize { get; set; }

		[W3Type("moonFlareColor")]
		public CEnvFlareColorParameters MoonFlareColor { get; set; }

	}
}
