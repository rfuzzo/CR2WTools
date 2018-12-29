using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphDampValueNode : CBehaviorGraphValueBaseNode
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

[REDProp("increaseSpeed")]
public float IncreaseSpeed { get; set;}

[REDProp("decreaseSpeed")]
public float DecreaseSpeed { get; set;}

[REDProp("absolute")]
public bool Absolute { get; set;}

[REDProp("startFromDefault")]
public bool StartFromDefault { get; set;}

[REDProp("defaultValue")]
public float DefaultValue { get; set;}

[REDProp("cachedDefaultValNode")]
public Ptr<CBehaviorGraphValueNode> CachedDefaultValNode { get; set;}

[REDProp("cachedIncSpeedNode")]
public Ptr<CBehaviorGraphValueNode> CachedIncSpeedNode { get; set;}

[REDProp("cachedDecSpeedNode")]
public Ptr<CBehaviorGraphValueNode> CachedDecSpeedNode { get; set;}

#endregion
}
}