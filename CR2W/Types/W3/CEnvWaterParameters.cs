
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvWaterParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("waterFlowIntensity")]
		public SSimpleCurve WaterFlowIntensity { get; set; }

		[W3Type("underwaterBrightness")]
		public SSimpleCurve UnderwaterBrightness { get; set; }

		[W3Type("underWaterFogIntensity")]
		public SSimpleCurve UnderWaterFogIntensity { get; set; }

		[W3Type("waterColor")]
		public SSimpleCurve WaterColor { get; set; }

		[W3Type("underWaterColor")]
		public SSimpleCurve UnderWaterColor { get; set; }

		[W3Type("waterFresnel")]
		public SSimpleCurve WaterFresnel { get; set; }

		[W3Type("waterCaustics")]
		public SSimpleCurve WaterCaustics { get; set; }

		[W3Type("waterFoamIntensity")]
		public SSimpleCurve WaterFoamIntensity { get; set; }

		[W3Type("waterAmbientScale")]
		public SSimpleCurve WaterAmbientScale { get; set; }

		[W3Type("waterDiffuseScale")]
		public SSimpleCurve WaterDiffuseScale { get; set; }

	}
}
