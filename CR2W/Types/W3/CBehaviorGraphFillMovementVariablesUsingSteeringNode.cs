using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorGraphFillMovementVariablesUsingSteeringNode : CBehaviorGraphBaseNode
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

[REDProp("fillRequestedMovementDirectionWSVariable")]
public bool FillRequestedMovementDirectionWSVariable { get; set;}

[REDProp("requestedMovementDirectionWSVariableName")]
public CName RequestedMovementDirectionWSVariableName { get; set;}

[REDProp("fillRequestedFacingDirectionWSVariable")]
public bool FillRequestedFacingDirectionWSVariable { get; set;}

[REDProp("requestedFacingDirectionWSVariableName")]
public CName RequestedFacingDirectionWSVariableName { get; set;}

#endregion
}
}