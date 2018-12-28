using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeNodeScriptedActionsListReaderDefinition : IBehTreeMetanodeDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("actionListVar")]
public CName ActionListVar { get; set;}

#endregion
}
}