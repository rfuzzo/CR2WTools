using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphChooseRecoverFromRagdollAnimNode : CBehaviorGraphNode
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

[REDProp("mode")]
public EBehaviorGraphChooseRecoverFromRagdollAnimMode Mode { get; set;}

[REDProp("additionalOneFrameRotationYaw")]
public float AdditionalOneFrameRotationYaw { get; set;}

[REDProp("pelvisBone")]
public CName PelvisBone { get; set;}

[REDProp("pelvisBoneFrontAxis")]
public EAxis PelvisBoneFrontAxis { get; set;}

[REDProp("pelvisBoneFrontAxisInverted")]
public bool PelvisBoneFrontAxisInverted { get; set;}

[REDProp("pelvisBoneWeight")]
public float PelvisBoneWeight { get; set;}

[REDProp("shoulderBone")]
public CName ShoulderBone { get; set;}

[REDProp("shoulderBoneFrontAxis")]
public EAxis ShoulderBoneFrontAxis { get; set;}

[REDProp("shoulderBoneFrontAxisInverted")]
public bool ShoulderBoneFrontAxisInverted { get; set;}

[REDProp("shoulderBoneWeight")]
public float ShoulderBoneWeight { get; set;}

[REDProp("cachedInputNodes")]
public Array<Ptr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

#endregion
}
}