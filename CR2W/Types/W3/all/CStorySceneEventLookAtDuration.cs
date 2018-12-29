using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneEventLookAtDuration : CStorySceneEventDuration
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

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("actor")]
public CName Actor { get; set;}

[REDProp("bodyTarget")]
public CName BodyTarget { get; set;}

[REDProp("bodyEnabled")]
public bool BodyEnabled { get; set;}

[REDProp("bodyInstant")]
public bool BodyInstant { get; set;}

[REDProp("bodyWeight")]
public float BodyWeight { get; set;}

[REDProp("bodyStaticPointWS")]
public Vector BodyStaticPointWS { get; set;}

[REDProp("type")]
public EDialogLookAtType Type { get; set;}

[REDProp("level")]
public ELookAtLevel Level { get; set;}

[REDProp("bodyTransitionWeight")]
public float BodyTransitionWeight { get; set;}

[REDProp("usesNewTransition")]
public bool UsesNewTransition { get; set;}

[REDProp("useTwoTargets")]
public bool UseTwoTargets { get; set;}

[REDProp("eyesTarget")]
public CName EyesTarget { get; set;}

[REDProp("eyesEnabled")]
public bool EyesEnabled { get; set;}

[REDProp("eyesInstant")]
public bool EyesInstant { get; set;}

[REDProp("eyesWeight")]
public float EyesWeight { get; set;}

[REDProp("eyesStaticPointWS")]
public Vector EyesStaticPointWS { get; set;}

[REDProp("eyesLookAtConvergenceWeight")]
public float EyesLookAtConvergenceWeight { get; set;}

[REDProp("eyesLookAtIsAdditive")]
public bool EyesLookAtIsAdditive { get; set;}

[REDProp("sceneRange")]
public float SceneRange { get; set;}

[REDProp("gameplayRange")]
public float GameplayRange { get; set;}

[REDProp("limitDeact")]
public bool LimitDeact { get; set;}

[REDProp("resetCloth")]
public EDialogResetClothAndDanglesType ResetCloth { get; set;}

[REDProp("oldLookAtEyesSpeed")]
public float OldLookAtEyesSpeed { get; set;}

[REDProp("oldLookAtEyesDampScale")]
public float OldLookAtEyesDampScale { get; set;}

[REDProp("blinkSettings")]
public SStorySceneEventLookAtBlinkSettings BlinkSettings { get; set;}

#endregion
}
}