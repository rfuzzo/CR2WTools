
using System;
using CR2W.Attributes;

namespace CR2W.Types.W3
{
	public class SMultiCurve
	{
		[W3Type("type")]
		public ECurveType Type { get; set; }

		[W3Type("color")]
		public Color Color { get; set; }

		[W3Type("showFlags")]
		public EShowFlags ShowFlags { get; set; }

		[W3Type("positionInterpolationMode")]
		public ECurveInterpolationMode PositionInterpolationMode { get; set; }

		[W3Type("positionManualMode")]
		public ECurveManualMode PositionManualMode { get; set; }

		[W3Type("rotationInterpolationMode")]
		public ECurveInterpolationMode RotationInterpolationMode { get; set; }

		[W3Type("totalTime")]
		public float TotalTime { get; set; }

		[W3Type("automaticPositionInterpolationSmoothness")]
		public float AutomaticPositionInterpolationSmoothness { get; set; }

		[W3Type("automaticRotationInterpolationSmoothness")]
		public float AutomaticRotationInterpolationSmoothness { get; set; }

		[W3Type("enableConsistentNumberOfControlPoints")]
		public bool EnableConsistentNumberOfControlPoints { get; set; }

		[W3Type("enableAutomaticTimeByDistanceRecalculation")]
		public bool EnableAutomaticTimeByDistanceRecalculation { get; set; }

		[W3Type("enableAutomaticTimeRecalculation")]
		public bool EnableAutomaticTimeRecalculation { get; set; }

		[W3Type("enableAutomaticRotationFromDirectionRecalculation")]
		public bool EnableAutomaticRotationFromDirectionRecalculation { get; set; }

		[W3Type("curves")]
        [W3ArrayFlags(2, 0)]
        public Array<SCurveData> Curves { get; set; }

		[W3Type("leftTangents")]
        [W3ArrayFlags(142, 0)]
        public Array<Vector> LeftTangents { get; set; }

		[W3Type("rightTangents")]
        [W3ArrayFlags(142, 0)]
        public Array<Vector> RightTangents { get; set; }

		[W3Type("easeParams")]
        [W3ArrayFlags(2, 0)]
        public Array<SCurveEaseParam> EaseParams { get; set; }

		[W3Type("translationRelativeMode")]
		public ECurveRelativeMode TranslationRelativeMode { get; set; }

		[W3Type("rotationRelativeMode")]
		public ECurveRelativeMode RotationRelativeMode { get; set; }

		[W3Type("scaleRelativeMode")]
		public ECurveRelativeMode ScaleRelativeMode { get; set; }

		[W3Type("initialParentTransform")]
		public EngineTransform InitialParentTransform { get; set; }

		[W3Type("hasInitialParentTransform")]
		public bool HasInitialParentTransform { get; set; }

	}
}
