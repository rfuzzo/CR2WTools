
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvSharpenParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("sharpenNear")]
		public SSimpleCurve SharpenNear { get; set; }

		[REDProp("sharpenFar")]
		public SSimpleCurve SharpenFar { get; set; }

		[REDProp("distanceNear")]
		public SSimpleCurve DistanceNear { get; set; }

		[REDProp("distanceFar")]
		public SSimpleCurve DistanceFar { get; set; }

		[REDProp("lumFilterOffset")]
		public SSimpleCurve LumFilterOffset { get; set; }

		[REDProp("lumFilterRange")]
		public SSimpleCurve LumFilterRange { get; set; }

	}
}
