using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphConstraintCameraDialog : CBehaviorGraphBaseNode
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

[REDProp("cameraBone")]
public string CameraBone { get; set;}

[REDProp("referenceZ")]
public float ReferenceZ { get; set;}

[REDProp("cachedControlValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

[REDProp("cachedSourceTargetValueNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedSourceTargetValueNode { get; set;}

[REDProp("cachedDestTargetValueNode")]
public Ptr<CBehaviorGraphVectorValueNode> CachedDestTargetValueNode { get; set;}

#endregion
}
}