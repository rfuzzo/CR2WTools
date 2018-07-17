
using System;


namespace CR2W.Types.W3
{
	public class CEnvFlareColorParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("color0")]
		public SSimpleCurve Color0 { get; set; }

		[REDProp("opacity0")]
		public SSimpleCurve Opacity0 { get; set; }

		[REDProp("color1")]
		public SSimpleCurve Color1 { get; set; }

		[REDProp("opacity1")]
		public SSimpleCurve Opacity1 { get; set; }

		[REDProp("color2")]
		public SSimpleCurve Color2 { get; set; }

		[REDProp("opacity2")]
		public SSimpleCurve Opacity2 { get; set; }

		[REDProp("color3")]
		public SSimpleCurve Color3 { get; set; }

		[REDProp("opacity3")]
		public SSimpleCurve Opacity3 { get; set; }

	}
}
