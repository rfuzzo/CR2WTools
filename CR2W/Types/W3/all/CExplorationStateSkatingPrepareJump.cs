using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateSkatingPrepareJump : CExplorationInterceptorStateAbstract
{
#region RED Properties

[REDProp("skateGlobal")]
public Handle<CExplorationSkatingGlobal> SkateGlobal { get; set;}

[REDProp("behAnimEnd")]
public CName BehAnimEnd { get; set;}

[REDProp("timeMax")]
public float TimeMax { get; set;}

[REDProp("flowImpulse")]
public float FlowImpulse { get; set;}

#endregion
}
}