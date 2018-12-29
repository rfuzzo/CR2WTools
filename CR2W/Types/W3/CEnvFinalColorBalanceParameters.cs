
using System;
using System.ComponentModel;

namespace CR2W.Types.W3
{
	[TypeConverter(typeof(ExpandableObjectConverter))]public class CEnvFinalColorBalanceParameters
	{
		[REDProp("activated")]
		public bool Activated { get; set; }

		[REDProp("activatedBalanceMap")]
		public bool ActivatedBalanceMap { get; set; }

		[REDProp("activatedParametricBalance")]
		public bool ActivatedParametricBalance { get; set; }

		[REDProp("vignetteWeights")]
		public SSimpleCurve VignetteWeights { get; set; }

		[REDProp("vignetteColor")]
		public SSimpleCurve VignetteColor { get; set; }

		[REDProp("vignetteOpacity")]
		public SSimpleCurve VignetteOpacity { get; set; }

		[REDProp("chromaticAberrationSize")]
		public SSimpleCurve ChromaticAberrationSize { get; set; }

		[REDProp("balanceMapLerp")]
		public SSimpleCurve BalanceMapLerp { get; set; }

		[REDProp("balanceMapAmount")]
		public SSimpleCurve BalanceMapAmount { get; set; }

		[REDProp("balanceMap0")]
		public Soft<CBitmapTexture> BalanceMap0 { get; set; }

		[REDProp("balanceMap1")]
		public Soft<CBitmapTexture> BalanceMap1 { get; set; }

		[REDProp("balancePostBrightness")]
		public SSimpleCurve BalancePostBrightness { get; set; }

		[REDProp("levelsShadows")]
		public SSimpleCurve LevelsShadows { get; set; }

		[REDProp("levelsMidtones")]
		public SSimpleCurve LevelsMidtones { get; set; }

		[REDProp("levelsHighlights")]
		public SSimpleCurve LevelsHighlights { get; set; }

		[REDProp("midtoneRangeMin")]
		public SSimpleCurve MidtoneRangeMin { get; set; }

		[REDProp("midtoneRangeMax")]
		public SSimpleCurve MidtoneRangeMax { get; set; }

		[REDProp("midtoneMarginMin")]
		public SSimpleCurve MidtoneMarginMin { get; set; }

		[REDProp("midtoneMarginMax")]
		public SSimpleCurve MidtoneMarginMax { get; set; }

		[REDProp("parametricBalanceLow")]
		public CEnvParametricBalanceParameters ParametricBalanceLow { get; set; }

		[REDProp("parametricBalanceMid")]
		public CEnvParametricBalanceParameters ParametricBalanceMid { get; set; }

		[REDProp("parametricBalanceHigh")]
		public CEnvParametricBalanceParameters ParametricBalanceHigh { get; set; }

	}
}
