using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CFormationKeepDistanceToMembersSteeringTask : IFormationFragmentarySteeringTask
{
#region RED Properties

[REDProp("importance")]
public float Importance { get; set;}

[REDProp("minDistance")]
public float MinDistance { get; set;}

[REDProp("desiredDistance")]
public float DesiredDistance { get; set;}

#endregion
}
}