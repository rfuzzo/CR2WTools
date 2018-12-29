using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PlayerAbilityManager : W3AbilityManager
{
#region RED Properties

[REDProp("skills")]
public Array<SSkill> Skills { get; set;}

[REDProp("resistStatsItems")]
public Array<Array<SResistanceValue>> ResistStatsItems { get; set;}

[REDProp("toxicityOffset")]
public float ToxicityOffset { get; set;}

[REDProp("pathPointsSpent")]
public Array<Int32> PathPointsSpent { get; set;}

[REDProp("skillSlots")]
public Array<SSkillSlot> SkillSlots { get; set;}

[REDProp("skillAbilities")]
public Array<CName> SkillAbilities { get; set;}

[REDProp("totalSkillSlotsCount")]
public Int32 TotalSkillSlotsCount { get; set;}

[REDProp("tempSkills")]
public Array<ESkill> TempSkills { get; set;}

[REDProp("mutagenSlots")]
public Array<SMutagenSlot> MutagenSlots { get; set;}

[REDProp("temporaryTutorialSkills")]
public Array<STutorialTemporarySkill> TemporaryTutorialSkills { get; set;}

[REDProp("ep1SkillsInitialized")]
public bool Ep1SkillsInitialized { get; set;}

[REDProp("ep2SkillsInitialized")]
public bool Ep2SkillsInitialized { get; set;}

[REDProp("baseGamePerksGUIPosUpdated")]
public bool BaseGamePerksGUIPosUpdated { get; set;}

[REDProp("mutagenBonuses")]
public Array<SMutagenBonusAlchemy19> MutagenBonuses { get; set;}

[REDProp("alchemy19OptimizationDone")]
public bool Alchemy19OptimizationDone { get; set;}

[REDProp("isMutationSystemEnabled")]
public bool IsMutationSystemEnabled { get; set;}

[REDProp("equippedMutation")]
public EPlayerMutationType EquippedMutation { get; set;}

[REDProp("mutations")]
public Array<SMutation> Mutations { get; set;}

[REDProp("mutationUnlockedSlotsIndexes")]
public Array<Int32> MutationUnlockedSlotsIndexes { get; set;}

[REDProp("mutationSkillSlotsInitialized")]
public bool MutationSkillSlotsInitialized { get; set;}

[REDProp("LINK_BONUS_BLUE")]
public CName LINK_BONUS_BLUE { get; set;}

[REDProp("LINK_BONUS_GREEN")]
public CName LINK_BONUS_GREEN { get; set;}

[REDProp("LINK_BONUS_RED")]
public CName LINK_BONUS_RED { get; set;}

[REDProp("MUTATION_SKILL_GROUP_ID")]
public Int32 MUTATION_SKILL_GROUP_ID { get; set;}

#endregion
}
}