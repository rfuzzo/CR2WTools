using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CStorySceneCutsceneSection : CStorySceneSection
{
#region RED Properties

[REDProp("linkedElements")]
public Array<Ptr<CStorySceneLinkElement>> LinkedElements { get; set;}

[REDProp("nextLinkElement")]
public Ptr<CStorySceneLinkElement> NextLinkElement { get; set;}

[REDProp("comment")]
public string Comment { get; set;}

[REDProp("contexID")]
public int ContexID { get; set;}

[REDProp("nextVariantId")]
public uint NextVariantId { get; set;}

[REDProp("defaultVariantId")]
public uint DefaultVariantId { get; set;}

[REDProp("variants")]
public Array<Ptr<CStorySceneSectionVariant>> Variants { get; set;}

[REDProp("localeVariantMappings")]
public Array<Ptr<CStorySceneLocaleVariantMapping>> LocaleVariantMappings { get; set;}

[REDProp("sceneElements")]
public Array<Ptr<CStorySceneElement>> SceneElements { get; set;}

[REDProp("events")]
public Array<Ptr<CStorySceneEvent>> Events { get; set;}

[REDProp("eventsInfo")]
public Array<Ptr<CStorySceneEventInfo>> EventsInfo { get; set;}

[REDProp("choice")]
public Ptr<CStorySceneChoice> Choice { get; set;}

[REDProp("sectionId")]
public uint SectionId { get; set;}

[REDProp("sectionName")]
public string SectionName { get; set;}

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("interceptRadius")]
public float InterceptRadius { get; set;}

[REDProp("interceptTimeout")]
public float InterceptTimeout { get; set;}

[REDProp("interceptSections")]
public Array<Ptr<CStorySceneSection>> InterceptSections { get; set;}

[REDProp("isGameplay")]
public bool IsGameplay { get; set;}

[REDProp("isImportant")]
public bool IsImportant { get; set;}

[REDProp("allowCameraMovement")]
public bool AllowCameraMovement { get; set;}

[REDProp("hasCinematicOneliners")]
public bool HasCinematicOneliners { get; set;}

[REDProp("manualFadeIn")]
public bool ManualFadeIn { get; set;}

[REDProp("fadeInAtBeginning")]
public bool FadeInAtBeginning { get; set;}

[REDProp("fadeOutAtEnd")]
public bool FadeOutAtEnd { get; set;}

[REDProp("pauseInCombat")]
public bool PauseInCombat { get; set;}

[REDProp("canBeSkipped")]
public bool CanBeSkipped { get; set;}

[REDProp("canHaveLookats")]
public bool CanHaveLookats { get; set;}

[REDProp("numberOfInputPaths")]
public uint NumberOfInputPaths { get; set;}

[REDProp("dialogsetChangeTo")]
public CName DialogsetChangeTo { get; set;}

[REDProp("forceDialogset")]
public bool ForceDialogset { get; set;}

[REDProp("inputPathsElements")]
public Array<Ptr<CStorySceneLinkElement>> InputPathsElements { get; set;}

[REDProp("streamingLock")]
public bool StreamingLock { get; set;}

[REDProp("streamingAreaTag")]
public CName StreamingAreaTag { get; set;}

[REDProp("streamingUseCameraPosition")]
public bool StreamingUseCameraPosition { get; set;}

[REDProp("streamingCameraAllowedJumpDistance")]
public float StreamingCameraAllowedJumpDistance { get; set;}

[REDProp("blockMusicTriggers")]
public bool BlockMusicTriggers { get; set;}

[REDProp("soundListenerOverride")]
public string SoundListenerOverride { get; set;}

[REDProp("soundEventsOnEnd")]
public Array<CName> SoundEventsOnEnd { get; set;}

[REDProp("soundEventsOnSkip")]
public Array<CName> SoundEventsOnSkip { get; set;}

[REDProp("maxBoxExtentsToApplyHiResShadows")]
public float MaxBoxExtentsToApplyHiResShadows { get; set;}

[REDProp("distantLightStartOverride")]
public float DistantLightStartOverride { get; set;}

[REDProp("cutscene")]
public Handle<CCutsceneTemplate> Cutscene { get; set;}

[REDProp("point")]
public TagList Point { get; set;}

[REDProp("looped")]
public bool Looped { get; set;}

[REDProp("actorOverrides")]
public Array<SCutsceneActorOverrideMapping> ActorOverrides { get; set;}

[REDProp("clearActorsHands")]
public bool ClearActorsHands { get; set;}

#endregion
}
}