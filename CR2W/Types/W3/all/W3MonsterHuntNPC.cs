using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MonsterHuntNPC : CNewNPC
{
#region RED Properties

[REDProp("MONSTER_HUNT_TARGET_TAG")]
public CName MONSTER_HUNT_TARGET_TAG { get; set;}

[REDProp("bossBarOn")]
public bool BossBarOn { get; set;}

[REDProp("musicOn")]
public bool MusicOn { get; set;}

[REDProp("displayBossBar")]
public bool DisplayBossBar { get; set;}

[REDProp("switchMusic")]
public bool SwitchMusic { get; set;}

[REDProp("questFocusSoundOnSpawn")]
public bool QuestFocusSoundOnSpawn { get; set;}

[REDProp("dontTagForAchievement")]
public bool DontTagForAchievement { get; set;}

[REDProp("disableDismemberment")]
public bool DisableDismemberment { get; set;}

[REDProp("combatMusicStartEvent")]
public string CombatMusicStartEvent { get; set;}

[REDProp("combatMusicStopEvent")]
public string CombatMusicStopEvent { get; set;}

[REDProp("associatedInvestigationAreasTag")]
public CName AssociatedInvestigationAreasTag { get; set;}

[REDProp("investigationAreasProcessed")]
public bool InvestigationAreasProcessed { get; set;}

#endregion
}
}