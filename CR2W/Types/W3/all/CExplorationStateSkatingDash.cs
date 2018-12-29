using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateSkatingDash : CExplorationStateAbstract
{
#region RED Properties

[REDProp("skateGlobal")]
public Handle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

[REDProp("impulse")]
public float Impulse { get; set;}

[REDProp("timeMax")]
public float TimeMax { get; set;}

[REDProp("timeToChainMin")]
public float TimeToChainMin { get; set;}

[REDProp("sharpTurnSpeed")]
public float SharpTurnSpeed { get; set;}

[REDProp("holdTurnSpeed")]
public float HoldTurnSpeed { get; set;}

[REDProp("sharpTurn")]
public bool SharpTurn { get; set;}

[REDProp("sharpTurnTime")]
public float SharpTurnTime { get; set;}

[REDProp("behAttackEvent")]
public CName BehAttackEvent { get; set;}

[REDProp("behLeftFootParam")]
public CName BehLeftFootParam { get; set;}

[REDProp("boneRightFoot")]
public CName BoneRightFoot { get; set;}

[REDProp("boneLeftFoot")]
public CName BoneLeftFoot { get; set;}

[REDProp("boneIndexRightFoot")]
public Int32 BoneIndexRightFoot { get; set;}

[REDProp("boneIndexLeftFoot")]
public Int32 BoneIndexLeftFoot { get; set;}

[REDProp("behEventEnd")]
public CName BehEventEnd { get; set;}

#endregion
}
}