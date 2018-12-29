
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvGameplayEffectsParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("catEffectBrightnessMultiply")]
		public SSimpleCurve CatEffectBrightnessMultiply { get; set; }

		[REDProp("behaviorAnimationMultiplier")]
		public SSimpleCurve BehaviorAnimationMultiplier { get; set; }

		[REDProp("specularityMultiplier")]
		public SSimpleCurve SpecularityMultiplier { get; set; }

		[REDProp("glossinessMultiplier")]
		public SSimpleCurve GlossinessMultiplier { get; set; }

	}
}
