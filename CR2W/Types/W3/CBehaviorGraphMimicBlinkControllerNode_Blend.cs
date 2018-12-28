using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphMimicBlinkControllerNode_Blend : CBehaviorGraphNode
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

[REDProp("trackEyeLeft_Down")]
public string TrackEyeLeft_Down { get; set;}

[REDProp("trackEyeRight_Down")]
public string TrackEyeRight_Down { get; set;}

[REDProp("blinkValueThr")]
public float BlinkValueThr { get; set;}

[REDProp("blinkCooldown")]
public float BlinkCooldown { get; set;}

[REDProp("cachedInputIdle")]
public Ptr<CBehaviorGraphNode> CachedInputIdle { get; set;}

[REDProp("cachedInputRest")]
public Ptr<CBehaviorGraphNode> CachedInputRest { get; set;}

#endregion
}
}