using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Elevator : CGameplayEntity
{
#region RED Properties

[REDProp("appearanceOnTop")]
public string AppearanceOnTop { get; set;}

[REDProp("appearanceOnGround")]
public string AppearanceOnGround { get; set;}

[REDProp("speed")]
public float Speed { get; set;}

[REDProp("currentHeight")]
public float CurrentHeight { get; set;}

[REDProp("targetNodeHeight")]
public float TargetNodeHeight { get; set;}

[REDProp("currentSpeed")]
public float CurrentSpeed { get; set;}

[REDProp("initialSpeed")]
public float InitialSpeed { get; set;}

[REDProp("isOnTop")]
public bool IsOnTop { get; set;}

[REDProp("movementStarted")]
public bool MovementStarted { get; set;}

[REDProp("onTopPosChecked")]
public bool OnTopPosChecked { get; set;}

[REDProp("initialHeight")]
public float InitialHeight { get; set;}

[REDProp("pos")]
public Vector Pos { get; set;}

[REDProp("onTopPos")]
public Vector OnTopPos { get; set;}

[REDProp("heightDifference")]
public float HeightDifference { get; set;}

[REDProp("goingUp")]
public bool GoingUp { get; set;}

[REDProp("playerOnElevator")]
public bool PlayerOnElevator { get; set;}

[REDProp("playerAttached")]
public bool PlayerAttached { get; set;}

[REDProp("deniedAreaCreated")]
public bool DeniedAreaCreated { get; set;}

[REDProp("blockedActions")]
public Array<EInputActionBlock> BlockedActions { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("deniedArea1")]
public Handle<CEntity> DeniedArea1 { get; set;}

[REDProp("deniedArea2")]
public Handle<CEntity> DeniedArea2 { get; set;}

[REDProp("deniedArea3")]
public Handle<CEntity> DeniedArea3 { get; set;}

#endregion
}
}