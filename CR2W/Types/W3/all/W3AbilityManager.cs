using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3AbilityManager : IScriptable
{
#region RED Properties

[REDProp("statPoints")]
public Array<SBaseStat> StatPoints { get; set;}

[REDProp("resistStats")]
public Array<SResistanceValue> ResistStats { get; set;}

[REDProp("blockedAbilities")]
public Array<SBlockedAbility> BlockedAbilities { get; set;}

[REDProp("owner")]
public Handle<CActor> Owner { get; set;}

[REDProp("charStats")]
public Handle<CCharacterStats> CharStats { get; set;}

[REDProp("usedDifficultyMode")]
public EDifficultyMode UsedDifficultyMode { get; set;}

[REDProp("usedHealthType")]
public EBaseCharacterStats UsedHealthType { get; set;}

[REDProp("difficultyAbilities")]
public Array<Array<CName>> DifficultyAbilities { get; set;}

[REDProp("ignoresDifficultySettings")]
public bool IgnoresDifficultySettings { get; set;}

#endregion
}
}