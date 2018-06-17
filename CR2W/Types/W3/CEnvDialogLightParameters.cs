
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvDialogLightParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("lightColor")]
		public SSimpleCurve LightColor { get; set; }

		[W3Type("lightColor2")]
		public SSimpleCurve LightColor2 { get; set; }

		[W3Type("lightColor3")]
		public SSimpleCurve LightColor3 { get; set; }

	}
}
