using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSpawnAnimDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("useSwarms")]
public bool UseSwarms { get; set;}

[REDProp("manageGravity")]
public bool ManageGravity { get; set;}

[REDProp("spawnCondition")]
public ESpawnCondition SpawnCondition { get; set;}

[REDProp("distToActors")]
public float DistToActors { get; set;}

[REDProp("delayMain")]
public float DelayMain { get; set;}

[REDProp("raiseEventName")]
public CName RaiseEventName { get; set;}

[REDProp("dealDamageOnAnimEvent")]
public CBehTreeValCName DealDamageOnAnimEvent { get; set;}

[REDProp("fxName")]
public CBehTreeValCName FxName { get; set;}

[REDProp("initialAppearance")]
public CName InitialAppearance { get; set;}

[REDProp("setAppearanceTo")]
public CName SetAppearanceTo { get; set;}

[REDProp("playFXOnAnimEvent")]
public CBehTreeValBool PlayFXOnAnimEvent { get; set;}

[REDProp("animEventNameActivator")]
public CBehTreeValCName AnimEventNameActivator { get; set;}

[REDProp("monitorGroundContact")]
public CBehTreeValBool MonitorGroundContact { get; set;}

[REDProp("becomeVisibleOnAnimEvent")]
public CBehTreeValCName BecomeVisibleOnAnimEvent { get; set;}

[REDProp("tagToBeDamaged")]
public CName TagToBeDamaged { get; set;}

#endregion
}
}