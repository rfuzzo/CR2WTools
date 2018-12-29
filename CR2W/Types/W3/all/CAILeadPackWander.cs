using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAILeadPackWander : CAIDynamicWander
{
#region RED Properties

[REDProp("leaderRegroupEvent")]
public CName LeaderRegroupEvent { get; set;}

[REDProp("followers")]
public Int32 Followers { get; set;}

[REDProp("canWanderRun")]
public bool CanWanderRun { get; set;}

[REDProp("chanceToRun")]
public float ChanceToRun { get; set;}

#endregion
}
}