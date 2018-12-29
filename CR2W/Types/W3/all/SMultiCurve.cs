using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SMultiCurve 
{
#region RED Properties

[REDProp("type")]
public ECurveType Type { get; set;}

[REDProp("color")]
public Color Color { get; set;}

[REDProp("showFlags")]
public EShowFlags ShowFlags { get; set;}

[REDProp("positionInterpolationMode")]
public ECurveInterpolationMode PositionInterpolationMode { get; set;}

[REDProp("positionManualMode")]
public ECurveManualMode PositionManualMode { get; set;}

[REDProp("rotationInterpolationMode")]
public ECurveInterpolationMode RotationInterpolationMode { get; set;}

[REDProp("totalTime")]
public float TotalTime { get; set;}

[REDProp("automaticPositionInterpolationSmoothness")]
public float AutomaticPositionInterpolationSmoothness { get; set;}

[REDProp("automaticRotationInterpolationSmoothness")]
public float AutomaticRotationInterpolationSmoothness { get; set;}

[REDProp("enableConsistentNumberOfControlPoints")]
public bool EnableConsistentNumberOfControlPoints { get; set;}

[REDProp("enableAutomaticTimeByDistanceRecalculation")]
public bool EnableAutomaticTimeByDistanceRecalculation { get; set;}

[REDProp("enableAutomaticTimeRecalculation")]
public bool EnableAutomaticTimeRecalculation { get; set;}

[REDProp("enableAutomaticRotationFromDirectionRecalculation")]
public bool EnableAutomaticRotationFromDirectionRecalculation { get; set;}

[REDProp("curves")]
public Array<SCurveData> Curves { get; set;}

[REDProp("leftTangents")]
public Array<Vector> LeftTangents { get; set;}

[REDProp("rightTangents")]
public Array<Vector> RightTangents { get; set;}

[REDProp("easeParams")]
public Array<SCurveEaseParam> EaseParams { get; set;}

[REDProp("translationRelativeMode")]
public ECurveRelativeMode TranslationRelativeMode { get; set;}

[REDProp("rotationRelativeMode")]
public ECurveRelativeMode RotationRelativeMode { get; set;}

[REDProp("scaleRelativeMode")]
public ECurveRelativeMode ScaleRelativeMode { get; set;}

[REDProp("initialParentTransform")]
public EngineTransform InitialParentTransform { get; set;}

[REDProp("hasInitialParentTransform")]
public bool HasInitialParentTransform { get; set;}

#endregion
}
}