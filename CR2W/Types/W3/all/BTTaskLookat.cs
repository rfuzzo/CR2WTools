using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskLookat : IBehTreeTask
{
#region RED Properties

[REDProp("lookatAtStart")]
public bool LookatAtStart { get; set;}

[REDProp("useHeadBoneRotation")]
public bool UseHeadBoneRotation { get; set;}

[REDProp("keepLooking")]
public bool KeepLooking { get; set;}

[REDProp("initKeeplooking")]
public bool InitKeeplooking { get; set;}

[REDProp("verticalLookAt")]
public bool VerticalLookAt { get; set;}

[REDProp("setAdditionalBehVar")]
public bool SetAdditionalBehVar { get; set;}

[REDProp("keepLookingAngle")]
public float KeepLookingAngle { get; set;}

[REDProp("additionalBehVarName")]
public CName AdditionalBehVarName { get; set;}

[REDProp("headBoneName")]
public CName HeadBoneName { get; set;}

[REDProp("isCombatTask")]
public bool IsCombatTask { get; set;}

[REDProp("lookAtTargetCheck")]
public bool LookAtTargetCheck { get; set;}

#endregion
}
}