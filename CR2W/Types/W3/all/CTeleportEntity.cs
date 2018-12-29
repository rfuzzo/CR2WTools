using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CTeleportEntity : CInteractiveEntity
{
#region RED Properties

[REDProp("keyItemName")]
public CName KeyItemName { get; set;}

[REDProp("removeKeyOnUse")]
public bool RemoveKeyOnUse { get; set;}

[REDProp("linkingMode")]
public bool LinkingMode { get; set;}

[REDProp("keepBlackscreen")]
public bool KeepBlackscreen { get; set;}

[REDProp("pairedTeleport")]
public EntityHandle PairedTeleport { get; set;}

[REDProp("pairedNodeTag")]
public CName PairedNodeTag { get; set;}

[REDProp("oneWayTeleport")]
public bool OneWayTeleport { get; set;}

[REDProp("activationTime")]
public float ActivationTime { get; set;}

[REDProp("factOnActivate")]
public string FactOnActivate { get; set;}

[REDProp("factOnTeleport")]
public string FactOnTeleport { get; set;}

[REDProp("factOnActivateValidFor")]
public Int32 FactOnActivateValidFor { get; set;}

[REDProp("factOnTeleportValidFor")]
public Int32 FactOnTeleportValidFor { get; set;}

[REDProp("isActivated")]
public bool IsActivated { get; set;}

[REDProp("destinationNode")]
public Handle<CNode> DestinationNode { get; set;}

[REDProp("currentlyTeleporting")]
public bool CurrentlyTeleporting { get; set;}

#endregion
}
}