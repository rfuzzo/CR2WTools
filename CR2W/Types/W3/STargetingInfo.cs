using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class STargetingInfo 
{
#region RED Properties

[REDProp("source")]
public Handle<CActor> Source { get; set;}

[REDProp("targetEntity")]
public Handle<CGameplayEntity> TargetEntity { get; set;}

[REDProp("canBeTargetedCheck")]
public bool CanBeTargetedCheck { get; set;}

[REDProp("coneCheck")]
public bool ConeCheck { get; set;}

[REDProp("coneHalfAngleCos")]
public float ConeHalfAngleCos { get; set;}

[REDProp("coneDist")]
public float ConeDist { get; set;}

[REDProp("coneHeadingVector")]
public Vector ConeHeadingVector { get; set;}

[REDProp("distCheck")]
public bool DistCheck { get; set;}

[REDProp("invisibleCheck")]
public bool InvisibleCheck { get; set;}

[REDProp("navMeshCheck")]
public bool NavMeshCheck { get; set;}

[REDProp("inFrameCheck")]
public bool InFrameCheck { get; set;}

[REDProp("frameScaleX")]
public float FrameScaleX { get; set;}

[REDProp("frameScaleY")]
public float FrameScaleY { get; set;}

[REDProp("knockDownCheck")]
public bool KnockDownCheck { get; set;}

[REDProp("knockDownCheckDist")]
public float KnockDownCheckDist { get; set;}

[REDProp("rsHeadingCheck")]
public bool RsHeadingCheck { get; set;}

[REDProp("rsHeadingLimitCos")]
public float RsHeadingLimitCos { get; set;}

#endregion
}
}