using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphChangeDirectionNode : CBehaviorGraphValueNode
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

[REDProp("anyDirection")]
public bool AnyDirection { get; set;}

[REDProp("angles")]
public Array<float> Angles { get; set;}

[REDProp("updateOnlyOnActivation")]
public bool UpdateOnlyOnActivation { get; set;}

[REDProp("dirBlendTime")]
public float DirBlendTime { get; set;}

[REDProp("dirMaxBlendSpeed")]
public float DirMaxBlendSpeed { get; set;}

[REDProp("overshootAngle")]
public float OvershootAngle { get; set;}

[REDProp("requestedFacingDirectionWSVariableName")]
public CName RequestedFacingDirectionWSVariableName { get; set;}

[REDProp("cachedRequestedFacingDirectionWSValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedRequestedFacingDirectionWSValueNode { get; set;}

#endregion
}
}