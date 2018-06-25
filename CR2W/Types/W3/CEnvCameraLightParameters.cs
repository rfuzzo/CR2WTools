
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvCameraLightParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("color")]
		public SSimpleCurve Color { get; set; }

		[REDProp("attenuation")]
		public SSimpleCurve Attenuation { get; set; }

		[REDProp("radius")]
		public SSimpleCurve Radius { get; set; }

		[REDProp("offsetFront")]
		public SSimpleCurve OffsetFront { get; set; }

		[REDProp("offsetRight")]
		public SSimpleCurve OffsetRight { get; set; }

		[REDProp("offsetUp")]
		public SSimpleCurve OffsetUp { get; set; }

	}
}
