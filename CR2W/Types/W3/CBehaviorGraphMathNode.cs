using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphMathNode : CBehaviorGraphValueNode
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

[REDProp("operation")]
public EBehaviorMathOp Operation { get; set;}

[REDProp("cachedFirstInputNode")]
public Ptr<CBehaviorGraphValueNode> CachedFirstInputNode { get; set;}

[REDProp("cachedSecondInputNode")]
public Ptr<CBehaviorGraphValueNode> CachedSecondInputNode { get; set;}

#endregion
}
}