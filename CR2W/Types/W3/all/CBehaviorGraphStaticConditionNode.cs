using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphStaticConditionNode : CBehaviorGraphNode
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("activateNotification")]
public CName ActivateNotification { get; set;}

[REDProp("deactivateNotification")]
public CName DeactivateNotification { get; set;}

[REDProp("generateEditorFragments")]
public bool GenerateEditorFragments { get; set;}

[REDProp("id")]
public uint Id { get; set;}

[REDProp("condition")]
public Ptr<IBehaviorGraphStaticCondition> Condition { get; set;}

[REDProp("cachedInputANode")]
public Ptr<CBehaviorGraphNode> CachedInputANode { get; set;}

[REDProp("cachedInputBNode")]
public Ptr<CBehaviorGraphNode> CachedInputBNode { get; set;}

#endregion
}
}