using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphFilterNode : CBehaviorGraphBaseNode
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

[REDProp("filterTransform")]
public bool FilterTransform { get; set;}

[REDProp("filterRotation")]
public bool FilterRotation { get; set;}

[REDProp("filterScale")]
public bool FilterScale { get; set;}

/*[REDProp("Bones with weights")]
public Array<SBehaviorGraphBoneInfo> Bones with weights { get; set;}*/

[REDProp("cachedControlNode")]
public Ptr<CBehaviorGraphValueNode> CachedControlNode { get; set;}

#endregion
}
}