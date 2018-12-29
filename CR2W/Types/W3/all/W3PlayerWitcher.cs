using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PlayerWitcher : CR4Player
{
#region RED Properties

[REDProp("craftingSchematics")]
public Array<CName> CraftingSchematics { get; set;}

[REDProp("expandedCraftingCategories")]
public Array<CName> ExpandedCraftingCategories { get; set;}

[REDProp("craftingFilters")]
public SCraftingFilters CraftingFilters { get; set;}

[REDProp("alchemyRecipes")]
public Array<CName> AlchemyRecipes { get; set;}

[REDProp("expandedAlchemyCategories")]
public Array<CName> ExpandedAlchemyCategories { get; set;}

[REDProp("alchemyFilters")]
public SCraftingFilters AlchemyFilters { get; set;}

[REDProp("expandedBestiaryCategories")]
public Array<CName> ExpandedBestiaryCategories { get; set;}

[REDProp("booksRead")]
public Array<CName> BooksRead { get; set;}

[REDProp("fastAttackCounter")]
public Int32 FastAttackCounter { get; set;}

[REDProp("heavyAttackCounter")]
public Int32 HeavyAttackCounter { get; set;}

[REDProp("isInFrenzy")]
public bool IsInFrenzy { get; set;}

[REDProp("hasRecentlyCountered")]
public bool HasRecentlyCountered { get; set;}

[REDProp("cannotUseUndyingSkill")]
public bool CannotUseUndyingSkill { get; set;}

[REDProp("amountOfSetPiecesEquipped")]
public Array<Int32> AmountOfSetPiecesEquipped { get; set;}

[REDProp("canSwitchFocusModeTarget")]
public bool CanSwitchFocusModeTarget { get; set;}

[REDProp("switchFocusModeTargetAllowed")]
public bool SwitchFocusModeTargetAllowed { get; set;}

[REDProp("signs")]
public Array<SWitcherSign> Signs { get; set;}

[REDProp("equippedSign")]
public ESignType EquippedSign { get; set;}

[REDProp("currentlyCastSign")]
public ESignType CurrentlyCastSign { get; set;}

[REDProp("signOwner")]
public Handle<W3SignOwnerPlayer> SignOwner { get; set;}

[REDProp("usedQuenInCombat")]
public bool UsedQuenInCombat { get; set;}

[REDProp("yrdenEntities")]
public Array<Handle<W3YrdenEntity>> YrdenEntities { get; set;}

[REDProp("m_quenReappliedCount")]
public Int32 M_quenReappliedCount { get; set;}

[REDProp("bDispalyHeavyAttackIndicator")]
public bool BDispalyHeavyAttackIndicator { get; set;}

[REDProp("bDisplayHeavyAttackFirstLevelTimer")]
public bool BDisplayHeavyAttackFirstLevelTimer { get; set;}

[REDProp("specialAttackHeavyAllowed")]
public bool SpecialAttackHeavyAllowed { get; set;}

[REDProp("companionNPCTag")]
public CName CompanionNPCTag { get; set;}

[REDProp("companionNPCTag2")]
public CName CompanionNPCTag2 { get; set;}

[REDProp("companionNPCIconPath")]
public string CompanionNPCIconPath { get; set;}

[REDProp("companionNPCIconPath2")]
public string CompanionNPCIconPath2 { get; set;}

[REDProp("itemSlots")]
public Array<SItemUniqueId> ItemSlots { get; set;}

[REDProp("remainingBombThrowDelaySlot1")]
public float RemainingBombThrowDelaySlot1 { get; set;}

[REDProp("remainingBombThrowDelaySlot2")]
public float RemainingBombThrowDelaySlot2 { get; set;}

[REDProp("previouslyUsedBolt")]
public SItemUniqueId PreviouslyUsedBolt { get; set;}

[REDProp("questMarkedSelectedQuickslotItems")]
public Array<SSelectedQuickslotItem> QuestMarkedSelectedQuickslotItems { get; set;}

[REDProp("tempLearnedSignSkills")]
public Array<SSimpleSkill> TempLearnedSignSkills { get; set;}

[REDProp("autoLevel")]
public bool AutoLevel { get; set;}

[REDProp("skillBonusPotionEffect")]
public Handle<CBaseGameplayEffect> SkillBonusPotionEffect { get; set;}

[REDProp("levelManager")]
public Handle<W3LevelManager> LevelManager { get; set;}

[REDProp("reputationManager")]
public Handle<W3Reputation> ReputationManager { get; set;}

[REDProp("medallionEntity")]
public Handle<CEntityTemplate> MedallionEntity { get; set;}

[REDProp("medallionController")]
public Handle<W3MedallionController> MedallionController { get; set;}

[REDProp("bShowRadialMenu")]
public bool BShowRadialMenu { get; set;}

[REDProp("_HoldBeforeOpenRadialMenuTime")]
public float _HoldBeforeOpenRadialMenuTime { get; set;}

[REDProp("MappinToHighlight")]
public Array<SHighlightMappin> MappinToHighlight { get; set;}

[REDProp("horseManagerHandle")]
public EntityHandle HorseManagerHandle { get; set;}

[REDProp("isInitialized")]
public bool IsInitialized { get; set;}

[REDProp("timeForPerk21")]
public float TimeForPerk21 { get; set;}

[REDProp("invUpdateTransaction")]
public bool InvUpdateTransaction { get; set;}

[REDProp("mutation12IsOnCooldown")]
public bool Mutation12IsOnCooldown { get; set;}

[REDProp("mutation11QuenEntity")]
public Handle<W3QuenEntity> Mutation11QuenEntity { get; set;}

[REDProp("storedInteractionPriority")]
public EInteractionPriority StoredInteractionPriority { get; set;}

[REDProp("selectedPotionSlotUpper")]
public EEquipmentSlots SelectedPotionSlotUpper { get; set;}

[REDProp("selectedPotionSlotLower")]
public EEquipmentSlots SelectedPotionSlotLower { get; set;}

[REDProp("potionDoubleTapTimerRunning")]
public bool PotionDoubleTapTimerRunning { get; set;}

[REDProp("potionDoubleTapSlotIsUpper")]
public bool PotionDoubleTapSlotIsUpper { get; set;}

[REDProp("findActorTargetTimeStamp")]
public float FindActorTargetTimeStamp { get; set;}

[REDProp("pcModeChanneledSignTimeStamp")]
public float PcModeChanneledSignTimeStamp { get; set;}

[REDProp("runewordInfusionType")]
public ESignType RunewordInfusionType { get; set;}

[REDProp("savedQuenHealth")]
public float SavedQuenHealth { get; set;}

[REDProp("savedQuenDuration")]
public float SavedQuenDuration { get; set;}

[REDProp("clockMenu")]
public Handle<CR4MeditationClockMenu> ClockMenu { get; set;}

[REDProp("waitTimeHour")]
public Int32 WaitTimeHour { get; set;}

[REDProp("runeword10TriggerredOnFinisher")]
public bool Runeword10TriggerredOnFinisher { get; set;}

[REDProp("runeword12TriggerredOnFinisher")]
public bool Runeword12TriggerredOnFinisher { get; set;}

#endregion
}
}