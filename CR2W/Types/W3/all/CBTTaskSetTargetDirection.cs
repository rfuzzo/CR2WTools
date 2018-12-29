using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSetTargetDirection : IBehTreeTask
{
#region RED Properties

[REDProp("npcPos")]
public Vector NpcPos { get; set;}

[REDProp("vec")]
public Vector Vec { get; set;}

[REDProp("curRot")]
public EulerAngles CurRot { get; set;}

[REDProp("rot")]
public EulerAngles Rot { get; set;}

[REDProp("angleDistance")]
public float AngleDistance { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("setRotationOnActivate")]
public bool SetRotationOnActivate { get; set;}

[REDProp("setOnAnimEvent")]
public bool SetOnAnimEvent { get; set;}

[REDProp("animationEventName")]
public CName AnimationEventName { get; set;}

[REDProp("useTargetsTarget")]
public bool UseTargetsTarget { get; set;}

[REDProp("completeOnAllowBlend")]
public bool CompleteOnAllowBlend { get; set;}

#endregion
}
}