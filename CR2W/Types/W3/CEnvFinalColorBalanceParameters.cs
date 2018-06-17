
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class CEnvFinalColorBalanceParameters
	{
		[W3Type("activated")]
		public bool Activated { get; set; }

		[W3Type("activatedBalanceMap")]
		public bool ActivatedBalanceMap { get; set; }

		[W3Type("activatedParametricBalance")]
		public bool ActivatedParametricBalance { get; set; }

		[W3Type("vignetteWeights")]
		public SSimpleCurve VignetteWeights { get; set; }

		[W3Type("vignetteColor")]
		public SSimpleCurve VignetteColor { get; set; }

		[W3Type("vignetteOpacity")]
		public SSimpleCurve VignetteOpacity { get; set; }

		[W3Type("chromaticAberrationSize")]
		public SSimpleCurve ChromaticAberrationSize { get; set; }

		[W3Type("balanceMapLerp")]
		public SSimpleCurve BalanceMapLerp { get; set; }

		[W3Type("balanceMapAmount")]
		public SSimpleCurve BalanceMapAmount { get; set; }

		[W3Type("balanceMap0")]
		public Soft<CBitmapTexture> BalanceMap0 { get; set; }

		[W3Type("balanceMap1")]
		public Soft<CBitmapTexture> BalanceMap1 { get; set; }

		[W3Type("balancePostBrightness")]
		public SSimpleCurve BalancePostBrightness { get; set; }

		[W3Type("levelsShadows")]
		public SSimpleCurve LevelsShadows { get; set; }

		[W3Type("levelsMidtones")]
		public SSimpleCurve LevelsMidtones { get; set; }

		[W3Type("levelsHighlights")]
		public SSimpleCurve LevelsHighlights { get; set; }

		[W3Type("midtoneRangeMin")]
		public SSimpleCurve MidtoneRangeMin { get; set; }

		[W3Type("midtoneRangeMax")]
		public SSimpleCurve MidtoneRangeMax { get; set; }

		[W3Type("midtoneMarginMin")]
		public SSimpleCurve MidtoneMarginMin { get; set; }

		[W3Type("midtoneMarginMax")]
		public SSimpleCurve MidtoneMarginMax { get; set; }

		[W3Type("parametricBalanceLow")]
		public CEnvParametricBalanceParameters ParametricBalanceLow { get; set; }

		[W3Type("parametricBalanceMid")]
		public CEnvParametricBalanceParameters ParametricBalanceMid { get; set; }

		[W3Type("parametricBalanceHigh")]
		public CEnvParametricBalanceParameters ParametricBalanceHigh { get; set; }

	}
}
