using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphCameraControllerNode : CBehaviorGraphBaseNode
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

[REDProp("valueScale")]
public float ValueScale { get; set;}

[REDProp("axis")]
public EAxis Axis { get; set;}

[REDProp("clamp")]
public bool Clamp { get; set;}

[REDProp("angleMin")]
public float AngleMin { get; set;}

[REDProp("angleMax")]
public float AngleMax { get; set;}

[REDProp("cachedControlInputNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlInputNode { get; set;}

[REDProp("cachedWeightInputNode")]
public Ptr<CBehaviorGraphValueNode> CachedWeightInputNode { get; set;}

[REDProp("cachedControlAngleInputNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlAngleInputNode { get; set;}

#endregion
}
}