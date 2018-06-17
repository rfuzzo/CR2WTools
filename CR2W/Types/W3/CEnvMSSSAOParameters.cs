
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvMSSSAOParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("noiseFilterTolerance")]
		public SSimpleCurve NoiseFilterTolerance { get; set; }

		[W3Type("blurTolerance")]
		public SSimpleCurve BlurTolerance { get; set; }

		[W3Type("upsampleTolerance")]
		public SSimpleCurve UpsampleTolerance { get; set; }

		[W3Type("rejectionFalloff")]
		public SSimpleCurve RejectionFalloff { get; set; }

		[W3Type("combineResolutionsBeforeBlur")]
		public bool CombineResolutionsBeforeBlur { get; set; }

		[W3Type("combineResolutionsWithMul")]
		public bool CombineResolutionsWithMul { get; set; }

		[W3Type("hierarchyDepth")]
		public SSimpleCurve HierarchyDepth { get; set; }

		[W3Type("normalAOMultiply")]
		public SSimpleCurve NormalAOMultiply { get; set; }

		[W3Type("normalToDepthBrightnessEqualiser")]
		public SSimpleCurve NormalToDepthBrightnessEqualiser { get; set; }

		[W3Type("normalBackProjectionTolerance")]
		public SSimpleCurve NormalBackProjectionTolerance { get; set; }

	}
}
