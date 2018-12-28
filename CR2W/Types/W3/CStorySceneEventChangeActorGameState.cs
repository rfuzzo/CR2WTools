using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneEventChangeActorGameState : CStorySceneEvent
{
#region RED Properties

[REDProp("eventName")]
public string EventName { get; set;}

[REDProp("startPosition")]
public float StartPosition { get; set;}

[REDProp("isMuted")]
public bool IsMuted { get; set;}

[REDProp("contexID")]
public int ContexID { get; set;}

[REDProp("sceneElement")]
public Ptr<CStorySceneElement> SceneElement { get; set;}

[REDProp("GUID")]
public CGUID GUID { get; set;}

[REDProp("interpolationEventGUID")]
public CGUID InterpolationEventGUID { get; set;}

[REDProp("blendParentGUID")]
public CGUID BlendParentGUID { get; set;}

[REDProp("linkParentGUID")]
public CGUID LinkParentGUID { get; set;}

[REDProp("linkParentTimeOffset")]
public float LinkParentTimeOffset { get; set;}

[REDProp("actor")]
public CName Actor { get; set;}

[REDProp("snapToTerrain")]
public bool SnapToTerrain { get; set;}

[REDProp("snapToTerrainDuration")]
public float SnapToTerrainDuration { get; set;}

[REDProp("blendPoseDuration")]
public float BlendPoseDuration { get; set;}

[REDProp("forceResetClothAndDangles")]
public bool ForceResetClothAndDangles { get; set;}

[REDProp("switchToGameplayPose")]
public bool SwitchToGameplayPose { get; set;}

[REDProp("gameplayPoseTypeName")]
public CName GameplayPoseTypeName { get; set;}

[REDProp("raiseGlobalBehaviorEvent")]
public CName RaiseGlobalBehaviorEvent { get; set;}

[REDProp("activateBehaviorGraph")]
public int ActivateBehaviorGraph { get; set;}

[REDProp("startGameplayAction")]
public int StartGameplayAction { get; set;}

#endregion
}
}