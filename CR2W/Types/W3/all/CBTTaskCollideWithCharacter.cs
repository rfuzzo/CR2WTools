using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCollideWithCharacter : IBehTreeTask
{
#region RED Properties

[REDProp("isAvailable")]
public bool IsAvailable { get; set;}

[REDProp("collideEndListenEventName")]
public CName CollideEndListenEventName { get; set;}

[REDProp("collideBehGrapEventName")]
public CName CollideBehGrapEventName { get; set;}

[REDProp("collidedConfirmedEvent")]
public CName CollidedConfirmedEvent { get; set;}

[REDProp("collidedDirBehGraphVar")]
public CName CollidedDirBehGraphVar { get; set;}

[REDProp("collidedPushBehGraphVar")]
public CName CollidedPushBehGraphVar { get; set;}

[REDProp("cooldownToRestartTotal")]
public float CooldownToRestartTotal { get; set;}

[REDProp("cooldownToStartTotal")]
public float CooldownToStartTotal { get; set;}

[REDProp("cooldownToRetryTotal")]
public float CooldownToRetryTotal { get; set;}

[REDProp("cooldownToPlayCur")]
public float CooldownToPlayCur { get; set;}

[REDProp("cooldownToRestartCur")]
public float CooldownToRestartCur { get; set;}

[REDProp("cooldownToRetryCur")]
public float CooldownToRetryCur { get; set;}

[REDProp("collidedActor")]
public Handle<CActor> CollidedActor { get; set;}

[REDProp("otherIsPlayer")]
public bool OtherIsPlayer { get; set;}

[REDProp("otherIsHorse")]
public bool OtherIsHorse { get; set;}

[REDProp("ignoreBumpOnOneGoingAway")]
public bool IgnoreBumpOnOneGoingAway { get; set;}

[REDProp("ignoreBumpOnBothGoingAway")]
public bool IgnoreBumpOnBothGoingAway { get; set;}

[REDProp("ignoreBumpOnBothStopped")]
public bool IgnoreBumpOnBothStopped { get; set;}

[REDProp("ignoreMinCoefToGoAway")]
public float IgnoreMinCoefToGoAway { get; set;}

[REDProp("ignoreMinSpeedSqr")]
public float IgnoreMinSpeedSqr { get; set;}

#endregion
}
}