using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphMimicGainNode : CBehaviorGraphBaseMimicNode
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
public Ptr<CBehaviorGraphNode> CachedInputNode { get; set;}

[REDProp("gain")]
public float Gain { get; set;}

[REDProp("min")]
public float Min { get; set;}

[REDProp("max")]
public float Max { get; set;}

[REDProp("cachedGainValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedGainValueNode { get; set;}

#endregion
}
}