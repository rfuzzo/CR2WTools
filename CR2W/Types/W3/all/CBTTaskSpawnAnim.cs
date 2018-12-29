using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSpawnAnim : IBehTreeTask
{
#region RED Properties

[REDProp("spawnCondition")]
public ESpawnCondition SpawnCondition { get; set;}

[REDProp("delayMain")]
public float DelayMain { get; set;}

[REDProp("time")]
public float Time { get; set;}

[REDProp("distToActors")]
public float DistToActors { get; set;}

[REDProp("manageGravity")]
public bool ManageGravity { get; set;}

[REDProp("raiseEventName")]
public CName RaiseEventName { get; set;}

[REDProp("fxName")]
public CName FxName { get; set;}

[REDProp("initialAppearance")]
public CName InitialAppearance { get; set;}

[REDProp("setAppearanceTo")]
public CName SetAppearanceTo { get; set;}

[REDProp("playFXOnAnimEvent")]
public bool PlayFXOnAnimEvent { get; set;}

[REDProp("animEventNameActivator")]
public CName AnimEventNameActivator { get; set;}

[REDProp("monitorGroundContact")]
public bool MonitorGroundContact { get; set;}

[REDProp("dealDamageOnAnimEvent")]
public CName DealDamageOnAnimEvent { get; set;}

[REDProp("becomeVisibleOnAnimEvent")]
public CName BecomeVisibleOnAnimEvent { get; set;}

[REDProp("tagToBeDamaged")]
public CName TagToBeDamaged { get; set;}

[REDProp("spawned")]
public bool Spawned { get; set;}

[REDProp("canPlayHitAnim")]
public bool CanPlayHitAnim { get; set;}

[REDProp("animEventOccured")]
public bool AnimEventOccured { get; set;}

[REDProp("isVisible")]
public bool IsVisible { get; set;}

#endregion
}
}