using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CGuardAreaParameters : IAISpawnTreeSubParameters
{
#region RED Properties

[REDProp("guardArea")]
public EntityHandle GuardArea { get; set;}

[REDProp("guardPursuitArea")]
public EntityHandle GuardPursuitArea { get; set;}

[REDProp("guardPursuitRange")]
public float GuardPursuitRange { get; set;}

#endregion
}
}