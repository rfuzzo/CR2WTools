using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeSelectFormationLeaderDefinition : CBehTreeNodeSelectPartyMemberDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("partyMemberName")]
public CBehTreeValCName PartyMemberName { get; set;}

[REDProp("formation")]
public CBehTreeValFormation Formation { get; set;}

#endregion
}
}