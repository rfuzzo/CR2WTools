using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphControlRigNode : CBehaviorGraphBaseNode
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

[REDProp("eHandLeftW")]
public CName EHandLeftW { get; set;}

[REDProp("eHandLeftP")]
public CName EHandLeftP { get; set;}

[REDProp("eHandRightW")]
public CName EHandRightW { get; set;}

[REDProp("eHandRightP")]
public CName EHandRightP { get; set;}

[REDProp("offsetHandLeft")]
public bool OffsetHandLeft { get; set;}

[REDProp("offsetHandRight")]
public bool OffsetHandRight { get; set;}

[REDProp("eHandLeftWeaponOffset")]
public CName EHandLeftWeaponOffset { get; set;}

[REDProp("eHandRightWeaponOffset")]
public CName EHandRightWeaponOffset { get; set;}

#endregion
}
}