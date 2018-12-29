using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CStoryScene : CResource
{
#region RED Properties

[REDProp("controlParts")]
public Array<Ptr<CStorySceneControlPart>> ControlParts { get; set;}

[REDProp("sections")]
public Array<Ptr<CStorySceneSection>> Sections { get; set;}

[REDProp("elementIDCounter")]
public uint ElementIDCounter { get; set;}

[REDProp("sectionIDCounter")]
public uint SectionIDCounter { get; set;}

[REDProp("sceneId")]
public uint SceneId { get; set;}

[REDProp("sceneTemplates")]
public Array<Ptr<CStorySceneActor>> SceneTemplates { get; set;}

[REDProp("sceneProps")]
public Array<Ptr<CStorySceneProp>> SceneProps { get; set;}

[REDProp("sceneEffects")]
public Array<Ptr<CStorySceneEffect>> SceneEffects { get; set;}

[REDProp("sceneLights")]
public Array<Ptr<CStorySceneLight>> SceneLights { get; set;}

[REDProp("mayActorsStartWorking")]
public bool MayActorsStartWorking { get; set;}

[REDProp("surpassWaterRendering")]
public bool SurpassWaterRendering { get; set;}

[REDProp("dialogsetInstances")]
public Array<Ptr<CStorySceneDialogsetInstance>> DialogsetInstances { get; set;}

[REDProp("cameraDefinitions")]
public Array<StorySceneCameraDefinition> CameraDefinitions { get; set;}

[REDProp("banksDependency")]
public Array<CName> BanksDependency { get; set;}

[REDProp("blockMusicTriggers")]
public bool BlockMusicTriggers { get; set;}

[REDProp("muteSpeechUnderWater")]
public bool MuteSpeechUnderWater { get; set;}

[REDProp("soundListenerOverride")]
public string SoundListenerOverride { get; set;}

[REDProp("soundEventsOnEnd")]
public Array<CName> SoundEventsOnEnd { get; set;}

[REDProp("soundEventsOnSkip")]
public Array<CName> SoundEventsOnSkip { get; set;}

#endregion
}
}