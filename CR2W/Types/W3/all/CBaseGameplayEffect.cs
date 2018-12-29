using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBaseGameplayEffect : CObject
{
#region RED Properties

[REDProp("timeActive")]
public float TimeActive { get; set;}

[REDProp("initialDuration")]
public float InitialDuration { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("timeLeft")]
public float TimeLeft { get; set;}

[REDProp("pauseCounters")]
public Array<SBuffPauseLock> PauseCounters { get; set;}

[REDProp("isActive")]
public bool IsActive { get; set;}

[REDProp("resistStat")]
public ECharacterDefenseStats ResistStat { get; set;}

[REDProp("resistance")]
public float Resistance { get; set;}

[REDProp("creatorPowerStat")]
public SAbilityAttributeValue CreatorPowerStat { get; set;}

[REDProp("isPausedDuringDialogAndCutscene")]
public bool IsPausedDuringDialogAndCutscene { get; set;}

[REDProp("dontAddAbilityOnTarget")]
public bool DontAddAbilityOnTarget { get; set;}

[REDProp("canBeAppliedOnDeadTarget")]
public bool CanBeAppliedOnDeadTarget { get; set;}

[REDProp("effectManager")]
public Handle<W3EffectManager> EffectManager { get; set;}

[REDProp("isPositive")]
public bool IsPositive { get; set;}

[REDProp("isNeutral")]
public bool IsNeutral { get; set;}

[REDProp("isNegative")]
public bool IsNegative { get; set;}

[REDProp("isOnPlayer")]
public bool IsOnPlayer { get; set;}

[REDProp("isSignEffect")]
public bool IsSignEffect { get; set;}

[REDProp("isPotionEffect")]
public bool IsPotionEffect { get; set;}

[REDProp("abilityName")]
public CName AbilityName { get; set;}

[REDProp("attributeName")]
public CName AttributeName { get; set;}

[REDProp("effectType")]
public EEffectType EffectType { get; set;}

[REDProp("target")]
public Handle<CActor> Target { get; set;}

[REDProp("creatorHandle")]
public EntityHandle CreatorHandle { get; set;}

[REDProp("effectValue")]
public SAbilityAttributeValue EffectValue { get; set;}

[REDProp("potionItemName")]
public CName PotionItemName { get; set;}

[REDProp("deny")]
public Array<EEffectType> Deny { get; set;}

[REDProp("override")]
public Array<EEffectType> Override { get; set;}

[REDProp("sourceName")]
public string SourceName { get; set;}

[REDProp("cameraEffectName")]
public CName CameraEffectName { get; set;}

[REDProp("isPlayingCameraEffect")]
public bool IsPlayingCameraEffect { get; set;}

[REDProp("switchCameraEffect")]
public bool SwitchCameraEffect { get; set;}

[REDProp("isCameraEffectNameValid")]
public bool IsCameraEffectNameValid { get; set;}

[REDProp("iconPath")]
public string IconPath { get; set;}

[REDProp("showOnHUD")]
public bool ShowOnHUD { get; set;}

[REDProp("effectNameLocalisationKey")]
public string EffectNameLocalisationKey { get; set;}

[REDProp("effectDescriptionLocalisationKey")]
public string EffectDescriptionLocalisationKey { get; set;}

[REDProp("targetEffectName")]
public CName TargetEffectName { get; set;}

[REDProp("shouldPlayTargetEffect")]
public bool ShouldPlayTargetEffect { get; set;}

[REDProp("onAddedSound")]
public CName OnAddedSound { get; set;}

[REDProp("onRemovedSound")]
public CName OnRemovedSound { get; set;}

[REDProp("vibratePadLowFreq")]
public float VibratePadLowFreq { get; set;}

[REDProp("vibratePadHighFreq")]
public float VibratePadHighFreq { get; set;}

#endregion
}
}