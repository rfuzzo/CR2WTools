using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehaviorGraphMapRangeNode : CBehaviorGraphValueBaseNode
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

[REDProp("minInValue")]
public float MinInValue { get; set;}

[REDProp("maxInValue")]
public float MaxInValue { get; set;}

[REDProp("minOutValue")]
public float MinOutValue { get; set;}

[REDProp("maxOutValue")]
public float MaxOutValue { get; set;}

[REDProp("base")]
public float Base { get; set;}

[REDProp("bias")]
public float Bias { get; set;}

#endregion
}
}