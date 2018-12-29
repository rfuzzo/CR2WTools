using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3EffectManager : CObject
{
#region RED Properties

[REDProp("owner")]
public Handle<CActor> Owner { get; set;}

[REDProp("effects")]
public Array<Handle<CBaseGameplayEffect>> Effects { get; set;}

[REDProp("statDeltas")]
public Array<float> StatDeltas { get; set;}

[REDProp("cachedDamages")]
public Array<SEffectCachedDamage> CachedDamages { get; set;}

[REDProp("isReady")]
public bool IsReady { get; set;}

[REDProp("currentlyAnimatedCS")]
public Handle<CBaseGameplayEffect> CurrentlyAnimatedCS { get; set;}

[REDProp("currentlyPlayedFX")]
public Array<SCurrentBuffFX> CurrentlyPlayedFX { get; set;}

[REDProp("pausedEffects")]
public Array<STemporarilyPausedEffect> PausedEffects { get; set;}

[REDProp("pausedNotAppliedAutoBuffs")]
public Array<SPausedAutoEffect> PausedNotAppliedAutoBuffs { get; set;}

[REDProp("ownerIsWitcher")]
public bool OwnerIsWitcher { get; set;}

[REDProp("isInitializingAutobuffs")]
public bool IsInitializingAutobuffs { get; set;}

[REDProp("hasCriticalStateSaveLock")]
public bool HasCriticalStateSaveLock { get; set;}

[REDProp("criticalStateSaveLockId")]
public Int32 CriticalStateSaveLockId { get; set;}

[REDProp("vitalityAutoRegenOn")]
public bool VitalityAutoRegenOn { get; set;}

[REDProp("essenceAutoRegenOn")]
public bool EssenceAutoRegenOn { get; set;}

[REDProp("staminaAutoRegenOn")]
public bool StaminaAutoRegenOn { get; set;}

[REDProp("moraleAutoRegenOn")]
public bool MoraleAutoRegenOn { get; set;}

[REDProp("panicAutoRegenOn")]
public bool PanicAutoRegenOn { get; set;}

[REDProp("airAutoRegenOn")]
public bool AirAutoRegenOn { get; set;}

[REDProp("swimmingStaminaAutoRegenOn")]
public bool SwimmingStaminaAutoRegenOn { get; set;}

[REDProp("adrenalineAutoRegenOn")]
public bool AdrenalineAutoRegenOn { get; set;}

#endregion
}
}