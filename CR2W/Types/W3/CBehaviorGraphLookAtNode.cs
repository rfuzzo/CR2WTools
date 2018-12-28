using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphLookAtNode : CBehaviorGraphBaseNode
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

[REDProp("boneName")]
public string BoneName { get; set;}

[REDProp("axis")]
public Vector Axis { get; set;}

[REDProp("useLimits")]
public bool UseLimits { get; set;}

[REDProp("limitAngle")]
public float LimitAngle { get; set;}

[REDProp("cachedValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedValueNode { get; set;}

[REDProp("cachedTargetNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedTargetNode { get; set;}

#endregion
}
}