using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneInput : CStorySceneControlPart
{
#region RED Properties

[REDProp("linkedElements")]
public Array<Ptr<CStorySceneLinkElement>> LinkedElements { get; set;}

[REDProp("nextLinkElement")]
public Ptr<CStorySceneLinkElement> NextLinkElement { get; set;}

[REDProp("comment")]
public string Comment { get; set;}

[REDProp("inputName")]
public string InputName { get; set;}

[REDProp("voicetagMappings")]
public Array<CStorySceneVoicetagMapping> VoicetagMappings { get; set;}

[REDProp("musicState")]
public ESoundStateDuringScene MusicState { get; set;}

[REDProp("ambientsState")]
public ESoundStateDuringScene AmbientsState { get; set;}

[REDProp("sceneNearPlane")]
public ENearPlaneDistance SceneNearPlane { get; set;}

[REDProp("sceneFarPlane")]
public EFarPlaneDistance SceneFarPlane { get; set;}

[REDProp("dontStopByExternalSystems")]
public bool DontStopByExternalSystems { get; set;}

[REDProp("maxActorsStaryingDistanceFromPlacement")]
public float MaxActorsStaryingDistanceFromPlacement { get; set;}

[REDProp("maxActorsStartingDistanceFormPlayer")]
public float MaxActorsStartingDistanceFormPlayer { get; set;}

[REDProp("dialogsetPlacementTag")]
public CName DialogsetPlacementTag { get; set;}

[REDProp("dialogsetInstanceName")]
public CName DialogsetInstanceName { get; set;}

[REDProp("enableIntroVehicleDismount")]
public bool EnableIntroVehicleDismount { get; set;}

[REDProp("enableIntroLookAts")]
public bool EnableIntroLookAts { get; set;}

[REDProp("introTotalTime")]
public float IntroTotalTime { get; set;}

[REDProp("enableIntroFadeOut")]
public bool EnableIntroFadeOut { get; set;}

[REDProp("introFadeOutStartTime")]
public float IntroFadeOutStartTime { get; set;}

[REDProp("blockSceneArea")]
public bool BlockSceneArea { get; set;}

[REDProp("enableDestroyDeadActorsAround")]
public bool EnableDestroyDeadActorsAround { get; set;}

[REDProp("isImportant")]
public bool IsImportant { get; set;}

[REDProp("isGameplay")]
public bool IsGameplay { get; set;}

#endregion
}
}