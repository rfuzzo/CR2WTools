using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateSkatingBackwards : CExplorationStateAbstract
{
#region RED Properties

[REDProp("skateGlobal")]
public Handle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

[REDProp("impulse")]
public float Impulse { get; set;}

[REDProp("impulseSpeedMax")]
public float ImpulseSpeedMax { get; set;}

[REDProp("sharpTurn")]
public bool SharpTurn { get; set;}

[REDProp("sharpTurnTime")]
public float SharpTurnTime { get; set;}

[REDProp("sharpTurnSpeed")]
public float SharpTurnSpeed { get; set;}

[REDProp("holdTurnSpeed")]
public float HoldTurnSpeed { get; set;}

[REDProp("chainTimeToDrift")]
public float ChainTimeToDrift { get; set;}

[REDProp("exiting")]
public bool Exiting { get; set;}

[REDProp("timeEndingMax")]
public float TimeEndingMax { get; set;}

[REDProp("timeEndingFlow")]
public bool TimeEndingFlow { get; set;}

[REDProp("timeEndingCur")]
public float TimeEndingCur { get; set;}

[REDProp("behDriftRestart")]
public CName BehDriftRestart { get; set;}

[REDProp("behDriftEnd")]
public CName BehDriftEnd { get; set;}

[REDProp("behDriftLeftSide")]
public CName BehDriftLeftSide { get; set;}

#endregion
}
}