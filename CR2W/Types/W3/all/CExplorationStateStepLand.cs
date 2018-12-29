using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateStepLand : CExplorationStateAbstract
{
#region RED Properties

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("fallCancelled")]
public bool FallCancelled { get; set;}

[REDProp("ended")]
public bool Ended { get; set;}

[REDProp("timeSafetyEnd")]
public float TimeSafetyEnd { get; set;}

[REDProp("directionToLand")]
public float DirectionToLand { get; set;}

[REDProp("timeToChainJump")]
public float TimeToChainJump { get; set;}

[REDProp("behAnimEnded")]
public CName BehAnimEnded { get; set;}

[REDProp("behLandRunS")]
public CName BehLandRunS { get; set;}

[REDProp("behAnimFall")]
public CName BehAnimFall { get; set;}

#endregion
}
}