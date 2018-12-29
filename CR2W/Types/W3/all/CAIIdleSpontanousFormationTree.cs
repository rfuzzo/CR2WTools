using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIIdleSpontanousFormationTree : IAIIdleFormationTree
{
#region RED Properties

[REDProp("partyMemberName")]
public CName PartyMemberName { get; set;}

[REDProp("leaderSteering")]
public Handle<CMoveSteeringBehavior> LeaderSteering { get; set;}

[REDProp("leadFormationTree")]
public Handle<CAIIdleTree> LeadFormationTree { get; set;}

[REDProp("loneWolfTree")]
public Handle<CAIIdleTree> LoneWolfTree { get; set;}

#endregion
}
}