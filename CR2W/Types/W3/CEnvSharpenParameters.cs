
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvSharpenParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("sharpenNear")]
		public SSimpleCurve SharpenNear { get; set; }

		[W3Type("sharpenFar")]
		public SSimpleCurve SharpenFar { get; set; }

		[W3Type("distanceNear")]
		public SSimpleCurve DistanceNear { get; set; }

		[W3Type("distanceFar")]
		public SSimpleCurve DistanceFar { get; set; }

		[W3Type("lumFilterOffset")]
		public SSimpleCurve LumFilterOffset { get; set; }

		[W3Type("lumFilterRange")]
		public SSimpleCurve LumFilterRange { get; set; }

	}
}
