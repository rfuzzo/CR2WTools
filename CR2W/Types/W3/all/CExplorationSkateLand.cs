using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationSkateLand : CExplorationStateAbstract
{
#region RED Properties

[REDProp("skateGlobal")]
public Handle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

[REDProp("behLandCancel")]
public CName BehLandCancel { get; set;}

[REDProp("timePrevToChain")]
public float TimePrevToChain { get; set;}

[REDProp("timeToChainJump")]
public float TimeToChainJump { get; set;}

[REDProp("timeSafetyEnd")]
public float TimeSafetyEnd { get; set;}

[REDProp("actionChained")]
public bool ActionChained { get; set;}

#endregion
}
}