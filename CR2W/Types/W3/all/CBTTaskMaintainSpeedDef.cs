using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskMaintainSpeedDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("moveType")]
public EMoveType MoveType { get; set;}

[REDProp("manageFlySpeed")]
public bool ManageFlySpeed { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("speedDecay")]
public bool SpeedDecay { get; set;}

[REDProp("speedDecayOnDeactivate")]
public bool SpeedDecayOnDeactivate { get; set;}

[REDProp("overrideForThisTask")]
public bool OverrideForThisTask { get; set;}

[REDProp("decayAfter")]
public float DecayAfter { get; set;}

#endregion
}
}