using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphAdjustDirectionNode : CBehaviorGraphBaseNode
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

[REDProp("animDirectionChange")]
public float AnimDirectionChange { get; set;}

[REDProp("updateAnimDirectionChangeFromAnimation")]
public bool UpdateAnimDirectionChangeFromAnimation { get; set;}

[REDProp("maxDirectionDiff")]
public float MaxDirectionDiff { get; set;}

[REDProp("maxOppositeDirectionDiff")]
public float MaxOppositeDirectionDiff { get; set;}

[REDProp("basedOnEvent")]
public CName BasedOnEvent { get; set;}

[REDProp("basedOnEventOverrideAnimation")]
public bool BasedOnEventOverrideAnimation { get; set;}

[REDProp("adjustmentBlendSpeed")]
public float AdjustmentBlendSpeed { get; set;}

[REDProp("requestedMovementDirectionVariableName")]
public CName RequestedMovementDirectionVariableName { get; set;}

[REDProp("cachedRequestedMovementDirectionWSValueNode")]
public Ptr<CBehaviorGraphValueNode> CachedRequestedMovementDirectionWSValueNode { get; set;}

#endregion
}
}