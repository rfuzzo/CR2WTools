using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateInteraction : CExplorationStateAbstract
{
#region RED Properties

[REDProp("explorationType")]
public ExplorationInteractionType ExplorationType { get; set;}

[REDProp("autointeract")]
public bool Autointeract { get; set;}

[REDProp("safetyTimeToExit")]
public float SafetyTimeToExit { get; set;}

[REDProp("useAutomaticExploration")]
public bool UseAutomaticExploration { get; set;}

[REDProp("allowOnDiving")]
public bool AllowOnDiving { get; set;}

[REDProp("timeBeforeExploring")]
public float TimeBeforeExploring { get; set;}

[REDProp("ladderCheckSides")]
public bool LadderCheckSides { get; set;}

[REDProp("ladderImpulseBack")]
public float LadderImpulseBack { get; set;}

[REDProp("ladderRangeFreeOfNPCs")]
public float LadderRangeFreeOfNPCs { get; set;}

[REDProp("cameraSetClimb")]
public Handle<CCameraParametersSet> CameraSetClimb { get; set;}

[REDProp("cameraOffsetBack")]
public float CameraOffsetBack { get; set;}

[REDProp("cameraOffsetUp")]
public float CameraOffsetUp { get; set;}

[REDProp("cameraPichInput")]
public float CameraPichInput { get; set;}

[REDProp("cameraBlendSpeedTrans")]
public float CameraBlendSpeedTrans { get; set;}

[REDProp("cameraBlendSpeedYaw")]
public float CameraBlendSpeedYaw { get; set;}

[REDProp("cameraBlendSpeedPitch")]
public float CameraBlendSpeedPitch { get; set;}

[REDProp("camPosOriginal")]
public Vector CamPosOriginal { get; set;}

[REDProp("camInitialized")]
public bool CamInitialized { get; set;}

[REDProp("cachedWeapon")]
public EPlayerWeapon CachedWeapon { get; set;}

[REDProp("restoreUsableItemLAtEnd")]
public bool RestoreUsableItemLAtEnd { get; set;}

#endregion
}
}