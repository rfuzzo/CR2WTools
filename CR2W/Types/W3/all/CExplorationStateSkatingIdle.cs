using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateSkatingIdle : CExplorationStateAbstract
{
#region RED Properties

[REDProp("skateGlobal")]
public Handle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

[REDProp("turnSpeed")]
public float TurnSpeed { get; set;}

[REDProp("turnStartTolerance")]
public float TurnStartTolerance { get; set;}

[REDProp("hackCiri")]
public bool HackCiri { get; set;}

[REDProp("behEventStart")]
public CName BehEventStart { get; set;}

[REDProp("behEventEnd")]
public CName BehEventEnd { get; set;}

#endregion
}
}