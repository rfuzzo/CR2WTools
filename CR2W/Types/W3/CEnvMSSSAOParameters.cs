
using System;


namespace CR2W.Types.W3
{
	public class CEnvMSSSAOParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("noiseFilterTolerance")]
		public SSimpleCurve NoiseFilterTolerance { get; set; }

		[REDProp("blurTolerance")]
		public SSimpleCurve BlurTolerance { get; set; }

		[REDProp("upsampleTolerance")]
		public SSimpleCurve UpsampleTolerance { get; set; }

		[REDProp("rejectionFalloff")]
		public SSimpleCurve RejectionFalloff { get; set; }

		[REDProp("combineResolutionsBeforeBlur")]
		public bool CombineResolutionsBeforeBlur { get; set; }

		[REDProp("combineResolutionsWithMul")]
		public bool CombineResolutionsWithMul { get; set; }

		[REDProp("hierarchyDepth")]
		public SSimpleCurve HierarchyDepth { get; set; }

		[REDProp("normalAOMultiply")]
		public SSimpleCurve NormalAOMultiply { get; set; }

		[REDProp("normalToDepthBrightnessEqualiser")]
		public SSimpleCurve NormalToDepthBrightnessEqualiser { get; set; }

		[REDProp("normalBackProjectionTolerance")]
		public SSimpleCurve NormalBackProjectionTolerance { get; set; }

	}
}
