using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphMimicPoseNode : CBehaviorGraphBaseMimicNode
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

[REDProp("poseType")]
public EMimicNodePoseType PoseType { get; set;}

[REDProp("poseName")]
public CName PoseName { get; set;}

[REDProp("cachedPoseValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedPoseValueNode { get; set;}

[REDProp("cachedPoseWeightNode")]
public Ptr<CBehaviorGraphValueNode> CachedPoseWeightNode { get; set;}

#endregion
}
}