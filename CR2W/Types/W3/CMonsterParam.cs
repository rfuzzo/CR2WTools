using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMonsterParam : CGameplayEntityParam
{
#region RED Properties

[REDProp("wasIncluded")]
public bool WasIncluded { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("overrideInherited")]
public bool OverrideInherited { get; set;}

[REDProp("isTeleporting")]
public bool IsTeleporting { get; set;}

[REDProp("canBeTargeted")]
public bool CanBeTargeted { get; set;}

[REDProp("canBeHitByFists")]
public bool CanBeHitByFists { get; set;}

[REDProp("canBeStrafed")]
public bool CanBeStrafed { get; set;}

[REDProp("monsterCategory")]
public int MonsterCategory { get; set;}

[REDProp("soundMonsterName")]
public CName SoundMonsterName { get; set;}

#endregion
}
}