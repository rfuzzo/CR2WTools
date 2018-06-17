
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvCameraLightParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("color")]
		public SSimpleCurve Color { get; set; }

		[W3Type("attenuation")]
		public SSimpleCurve Attenuation { get; set; }

		[W3Type("radius")]
		public SSimpleCurve Radius { get; set; }

		[W3Type("offsetFront")]
		public SSimpleCurve OffsetFront { get; set; }

		[W3Type("offsetRight")]
		public SSimpleCurve OffsetRight { get; set; }

		[W3Type("offsetUp")]
		public SSimpleCurve OffsetUp { get; set; }

	}
}
