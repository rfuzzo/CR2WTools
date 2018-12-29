using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphAnimationEnumSequentialSwitchNode : CBehaviorGraphAnimationEnumSwitchNode
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

[REDProp("inputNum")]
public uint InputNum { get; set;}

[REDProp("cachedInputNodes")]
public Array<Ptr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

[REDProp("cachedControlValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

[REDProp("cachedBlendTimeValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedBlendTimeValueNode { get; set;}

[REDProp("blendTime")]
public float BlendTime { get; set;}

[REDProp("interpolation")]
public EInterpolationType Interpolation { get; set;}

[REDProp("synchronizeOnSwitch")]
public bool SynchronizeOnSwitch { get; set;}

[REDProp("syncOnSwitchMethod")]
public Ptr<IBehaviorSyncMethod> SyncOnSwitchMethod { get; set;}

[REDProp("enum")]
public CName Enum { get; set;}

[REDProp("firstInputNum")]
public int FirstInputNum { get; set;}

#endregion
}
}