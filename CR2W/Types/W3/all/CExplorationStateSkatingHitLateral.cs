using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateSkatingHitLateral : CExplorationStateAbstract
{
#region RED Properties

[REDProp("skateGlobal")]
public Handle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

[REDProp("behAnimEnd")]
public CName BehAnimEnd { get; set;}

[REDProp("timeMax")]
public float TimeMax { get; set;}

[REDProp("speedMinToEnter")]
public float SpeedMinToEnter { get; set;}

[REDProp("speedReductionPerc")]
public float SpeedReductionPerc { get; set;}

[REDProp("extraAngle")]
public float ExtraAngle { get; set;}

#endregion
}
}