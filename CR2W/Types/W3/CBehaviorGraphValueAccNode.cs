using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphValueAccNode : CBehaviorGraphValueBaseNode
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

[REDProp("cachedInputNode")]
public Ptr<CBehaviorGraphValueNode> CachedInputNode { get; set;}

[REDProp("resetOnActivation")]
public bool ResetOnActivation { get; set;}

[REDProp("initValue")]
public float InitValue { get; set;}

[REDProp("wrapValue")]
public bool WrapValue { get; set;}

[REDProp("wrapValueThrMax")]
public float WrapValueThrMax { get; set;}

[REDProp("wrapValueThrMin")]
public float WrapValueThrMin { get; set;}

#endregion
}
}