using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateSkateJump : CExplorationStateJump
{
#region RED Properties

[REDProp("skateGlobal")]
public Handle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

[REDProp("attacked")]
public bool Attacked { get; set;}

[REDProp("attacktimeMin")]
public float AttacktimeMin { get; set;}

[REDProp("attackVertSpeedMin")]
public float AttackVertSpeedMin { get; set;}

[REDProp("attackVertSpeedImpulse")]
public float AttackVertSpeedImpulse { get; set;}

#endregion
}
}