using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneEventLookAt : CStorySceneEvent
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

[REDProp("target")]
public CName Target { get; set;}

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("type")]
public EDialogLookAtType Type { get; set;}

[REDProp("speed")]
public float Speed { get; set;}

[REDProp("level")]
public ELookAtLevel Level { get; set;}

[REDProp("range")]
public float Range { get; set;}

[REDProp("gameplayRange")]
public float GameplayRange { get; set;}

[REDProp("limitDeact")]
public bool LimitDeact { get; set;}

[REDProp("instant")]
public bool Instant { get; set;}

[REDProp("staticPoint")]
public Vector StaticPoint { get; set;}

[REDProp("headRotationRatio")]
public float HeadRotationRatio { get; set;}

[REDProp("eyesLookAtConvergenceWeight")]
public float EyesLookAtConvergenceWeight { get; set;}

[REDProp("eyesLookAtIsAdditive")]
public bool EyesLookAtIsAdditive { get; set;}

[REDProp("eyesLookAtDampScale")]
public float EyesLookAtDampScale { get; set;}

[REDProp("resetCloth")]
public EDialogResetClothAndDanglesType ResetCloth { get; set;}

#endregion
}
}