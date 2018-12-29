using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SPoseLookAtSegmentData 
{
#region RED Properties

[REDProp("segmentLevel")]
public ELookAtLevel SegmentLevel { get; set;}

[REDProp("boneNameFirst")]
public string BoneNameFirst { get; set;}

[REDProp("boneNameLast")]
public string BoneNameLast { get; set;}

[REDProp("weight")]
public float Weight { get; set;}

[REDProp("bendingMultiplier")]
public float BendingMultiplier { get; set;}

[REDProp("responsiveness")]
public float Responsiveness { get; set;}

[REDProp("propagateToChain")]
public bool PropagateToChain { get; set;}

[REDProp("onlyFirst")]
public bool OnlyFirst { get; set;}

[REDProp("up")]
public EAxis Up { get; set;}

[REDProp("front")]
public EAxis Front { get; set;}

[REDProp("angleMaxHor")]
public float AngleMaxHor { get; set;}

[REDProp("angleMaxVer")]
public float AngleMaxVer { get; set;}

[REDProp("angleThresholdDiffHor")]
public float AngleThresholdDiffHor { get; set;}

[REDProp("angleThresholdDiffVer")]
public float AngleThresholdDiffVer { get; set;}

[REDProp("maxAngleDiffHor")]
public float MaxAngleDiffHor { get; set;}

[REDProp("maxAngleDiffVer")]
public float MaxAngleDiffVer { get; set;}

[REDProp("maxAngleVerToRefPose")]
public float MaxAngleVerToRefPose { get; set;}

[REDProp("maxAngleHorToRefPose")]
public float MaxAngleHorToRefPose { get; set;}

#endregion
}
}