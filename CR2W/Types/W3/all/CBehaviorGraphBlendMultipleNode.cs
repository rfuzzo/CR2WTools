using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphBlendMultipleNode : CBehaviorGraphNode
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

[REDProp("synchronize")]
public bool Synchronize { get; set;}

[REDProp("syncMethod")]
public Ptr<IBehaviorSyncMethod> SyncMethod { get; set;}

[REDProp("inputValues")]
public Array<float> InputValues { get; set;}

[REDProp("minControlValue")]
public float MinControlValue { get; set;}

[REDProp("maxControlValue")]
public float MaxControlValue { get; set;}

[REDProp("radialBlending")]
public bool RadialBlending { get; set;}

[REDProp("takeEventsFromMoreImportantInput")]
public bool TakeEventsFromMoreImportantInput { get; set;}

[REDProp("cachedInputNodes")]
public Array<Ptr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

[REDProp("cachedControlValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

[REDProp("cachedMinControlValue")]
public Ptr<CBehaviorGraphValueNode> CachedMinControlValue { get; set;}

[REDProp("cachedMaxControlValue")]
public Ptr<CBehaviorGraphValueNode> CachedMaxControlValue { get; set;}

#endregion
}
}