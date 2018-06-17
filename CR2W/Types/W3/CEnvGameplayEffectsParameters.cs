
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvGameplayEffectsParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("catEffectBrightnessMultiply")]
		public SSimpleCurve CatEffectBrightnessMultiply { get; set; }

		[W3Type("behaviorAnimationMultiplier")]
		public SSimpleCurve BehaviorAnimationMultiplier { get; set; }

		[W3Type("specularityMultiplier")]
		public SSimpleCurve SpecularityMultiplier { get; set; }

		[W3Type("glossinessMultiplier")]
		public SSimpleCurve GlossinessMultiplier { get; set; }

	}
}
