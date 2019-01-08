using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3NewDoor : W3LockableEntity
{
#region RED Properties

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

[REDProp("transformParent")]
public Ptr<CHardAttachment> TransformParent { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("components", 2,0)]
public Array<Ptr<CComponent>> Components { get; set;}

[REDProp("template")]
public Handle<CEntityTemplate> Template { get; set;}

[REDProp("streamingDataBuffer")]
public SharedDataBuffer StreamingDataBuffer { get; set;}

[REDProp("streamingDistance")]
public byte StreamingDistance { get; set;}

[REDProp("entityStaticFlags")]
public EEntityStaticFlags EntityStaticFlags { get; set;}

[REDProp("autoPlayEffectName")]
public CName AutoPlayEffectName { get; set;}

[REDProp("entityFlags")]
public byte EntityFlags { get; set;}

[REDProp("idTag")]
public IdTag IdTag { get; set;}

[REDProp("isSaveable")]
public bool IsSaveable { get; set;}

[REDProp("propertyAnimationSet")]
public Ptr<CPropertyAnimationSet> PropertyAnimationSet { get; set;}

[REDProp("displayName")]
public LocalizedString DisplayName { get; set;}

[REDProp("stats")]
public Ptr<CCharacterStats> Stats { get; set;}

[REDProp("isInteractionActivator")]
public bool IsInteractionActivator { get; set;}

[REDProp("aimVector")]
public Vector AimVector { get; set;}

[REDProp("gameplayFlags")]
public UInt32 GameplayFlags { get; set;}

[REDProp("focusModeVisibility")]
public EFocusModeVisibility FocusModeVisibility { get; set;}

[REDProp("minLootParamNumber")]
public Int32 MinLootParamNumber { get; set;}

[REDProp("maxLootParamNumber")]
public Int32 MaxLootParamNumber { get; set;}

[REDProp("iconOffset")]
public Vector IconOffset { get; set;}

[REDProp("highlighted")]
public bool Highlighted { get; set;}

[REDProp("focusModeSoundEffectType")]
public EFocusModeSoundEffectType FocusModeSoundEffectType { get; set;}

[REDProp("isPlayingFocusSound")]
public bool IsPlayingFocusSound { get; set;}

[REDProp("isColorBlindMode")]
public bool IsColorBlindMode { get; set;}

[REDProp("focusSoundVisualEffectBoneName")]
public CName FocusSoundVisualEffectBoneName { get; set;}

[REDProp("isHighlightedByMedallion")]
public bool IsHighlightedByMedallion { get; set;}

[REDProp("isMagicalObject")]
public bool IsMagicalObject { get; set;}

[REDProp("soundEntityName")]
public string SoundEntityName { get; set;}

[REDProp("soundEntityGender")]
public string SoundEntityGender { get; set;}

[REDProp("soundEntitySet")]
public string SoundEntitySet { get; set;}

[REDProp("cutsceneForbiddenFXs", 2,0)]
public Array<CName> CutsceneForbiddenFXs { get; set;}

[REDProp("isEnabledOnSpawn")]
public bool IsEnabledOnSpawn { get; set;}

[REDProp("lockedByKey")]
public bool LockedByKey { get; set;}

[REDProp("keyItemName")]
public CName KeyItemName { get; set;}

[REDProp("removeKeyOnUse")]
public bool RemoveKeyOnUse { get; set;}

[REDProp("enabledByFact")]
public string EnabledByFact { get; set;}

[REDProp("factOnLockedAttempt")]
public string FactOnLockedAttempt { get; set;}

[REDProp("factOnUnlockedByKey")]
public string FactOnUnlockedByKey { get; set;}

[REDProp("mainInteractionComponent")]
public Handle<CDoorComponent> MainInteractionComponent { get; set;}

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

[REDProp("isPlayerInActivationRange")]
public bool IsPlayerInActivationRange { get; set;}

[REDProp("isInteractionBlocked")]
public bool IsInteractionBlocked { get; set;}

[REDProp("openAngle")]
public float OpenAngle { get; set;}

[REDProp("initiallyOpened")]
public bool InitiallyOpened { get; set;}

[REDProp("factOnPlayerDoorOpen")]
public CName FactOnPlayerDoorOpen { get; set;}

[REDProp("openedByHorse")]
public bool OpenedByHorse { get; set;}

[REDProp("doorsCmp")]
public Handle<CDoorComponent> DoorsCmp { get; set;}

[REDProp("lockedCmp")]
public Handle<CInteractionComponent> LockedCmp { get; set;}

[REDProp("unlockCmp")]
public Handle<CInteractionComponent> UnlockCmp { get; set;}

[REDProp("lockedDA")]
public Handle<CDeniedAreaComponent> LockedDA { get; set;}

[REDProp("rigidMeshCmp")]
public Handle<CRigidMeshComponent> RigidMeshCmp { get; set;}

[REDProp("updateDuration")]
public float UpdateDuration { get; set;}

[REDProp("updateTimeLeft")]
public float UpdateTimeLeft { get; set;}

[REDProp("playerInsideTrapdoorTrigger")]
public bool PlayerInsideTrapdoorTrigger { get; set;}

[REDProp("enableDeniedAreaInCombat")]
public bool EnableDeniedAreaInCombat { get; set;}

#endregion
}
}