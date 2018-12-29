
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvWaterParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("waterFlowIntensity")]
		public SSimpleCurve WaterFlowIntensity { get; set; }

		[REDProp("underwaterBrightness")]
		public SSimpleCurve UnderwaterBrightness { get; set; }

		[REDProp("underWaterFogIntensity")]
		public SSimpleCurve UnderWaterFogIntensity { get; set; }

		[REDProp("waterColor")]
		public SSimpleCurve WaterColor { get; set; }

		[REDProp("underWaterColor")]
		public SSimpleCurve UnderWaterColor { get; set; }

		[REDProp("waterFresnel")]
		public SSimpleCurve WaterFresnel { get; set; }

		[REDProp("waterCaustics")]
		public SSimpleCurve WaterCaustics { get; set; }

		[REDProp("waterFoamIntensity")]
		public SSimpleCurve WaterFoamIntensity { get; set; }

		[REDProp("waterAmbientScale")]
		public SSimpleCurve WaterAmbientScale { get; set; }

		[REDProp("waterDiffuseScale")]
		public SSimpleCurve WaterDiffuseScale { get; set; }

	}
}
