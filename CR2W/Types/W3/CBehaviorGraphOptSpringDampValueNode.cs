using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphOptSpringDampValueNode : CBehaviorGraphValueBaseNode
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

[REDProp("cachedSmoothTimeNode")]
public Ptr<CBehaviorGraphValueNode> CachedSmoothTimeNode { get; set;}

[REDProp("smoothTime")]
public float SmoothTime { get; set;}

[REDProp("scale")]
public float Scale { get; set;}

[REDProp("maxSpeed")]
public float MaxSpeed { get; set;}

[REDProp("maxDiff")]
public float MaxDiff { get; set;}

[REDProp("defaultValue")]
public float DefaultValue { get; set;}

[REDProp("forceInputValueOnActivate")]
public bool ForceInputValueOnActivate { get; set;}

[REDProp("forceDefaultValueOnActivate")]
public bool ForceDefaultValueOnActivate { get; set;}

#endregion
}
}