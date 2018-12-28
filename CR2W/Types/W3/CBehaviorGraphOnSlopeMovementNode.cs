using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphOnSlopeMovementNode : CBehaviorGraphValueNode
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

[REDProp("angles")]
public Array<float> Angles { get; set;}

[REDProp("slopeBlendTime")]
public float SlopeBlendTime { get; set;}

[REDProp("slopeMaxBlendSpeed")]
public float SlopeMaxBlendSpeed { get; set;}

[REDProp("neverReachBorderValues")]
public bool NeverReachBorderValues { get; set;}

#endregion
}
}