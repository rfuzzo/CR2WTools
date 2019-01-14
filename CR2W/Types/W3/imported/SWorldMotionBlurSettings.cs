using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SWorldMotionBlurSettings 
{
#region RED Properties

[REDProp("isPostTonemapping")]
public bool IsPostTonemapping { get; set;}

[REDProp("distanceNear")]
public float DistanceNear { get; set;}

[REDProp("distanceRange")]
public float DistanceRange { get; set;}

[REDProp("strengthNear")]
public float StrengthNear { get; set;}

[REDProp("strengthFar")]
public float StrengthFar { get; set;}

[REDProp("fullBlendOverPixels")]
public float FullBlendOverPixels { get; set;}

[REDProp("standoutDistanceNear")]
public float StandoutDistanceNear { get; set;}

[REDProp("standoutDistanceRange")]
public float StandoutDistanceRange { get; set;}

[REDProp("standoutAmountNear")]
public float StandoutAmountNear { get; set;}

[REDProp("standoutAmountFar")]
public float StandoutAmountFar { get; set;}

[REDProp("sharpenAmount")]
public float SharpenAmount { get; set;}

#endregion
}
}