using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIUseExplorationActionTree : IAIExplorationTree
{
#region RED Properties

[REDProp("explorationType")]
public EExplorationType ExplorationType { get; set;}

[REDProp("skipTeleportation")]
public bool SkipTeleportation { get; set;}

#endregion
}
}