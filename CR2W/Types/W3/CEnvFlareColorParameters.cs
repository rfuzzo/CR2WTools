
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvFlareColorParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("color0")]
		public SSimpleCurve Color0 { get; set; }

		[W3Type("opacity0")]
		public SSimpleCurve Opacity0 { get; set; }

		[W3Type("color1")]
		public SSimpleCurve Color1 { get; set; }

		[W3Type("opacity1")]
		public SSimpleCurve Opacity1 { get; set; }

		[W3Type("color2")]
		public SSimpleCurve Color2 { get; set; }

		[W3Type("opacity2")]
		public SSimpleCurve Opacity2 { get; set; }

		[W3Type("color3")]
		public SSimpleCurve Color3 { get; set; }

		[W3Type("opacity3")]
		public SSimpleCurve Opacity3 { get; set; }

	}
}
