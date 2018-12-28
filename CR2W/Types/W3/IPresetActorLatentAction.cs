using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class IPresetActorLatentAction : IActorLatentAction
{
#region RED Properties

[REDProp("res")]
public Handle<CBehTree> Res { get; set;}

[REDProp("def")]
public Ptr<CBehTreeNodeTemplateDefinition> Def { get; set;}

[REDProp("resName")]
public string ResName { get; set;}

#endregion
}
}