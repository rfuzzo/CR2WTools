using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class IFormationFragmentarySteeringTask : IFormationSteeringTask
{
#region RED Properties

[REDProp("importance")]
public float Importance { get; set;}

#endregion
}
}