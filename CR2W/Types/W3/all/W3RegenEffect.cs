using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3RegenEffect : CBaseGameplayEffect
{
#region RED Properties

[REDProp("regenStat")]
public ECharacterRegenStats RegenStat { get; set;}

[REDProp("stat")]
public EBaseCharacterStats Stat { get; set;}

[REDProp("isOnMonster")]
public bool IsOnMonster { get; set;}

#endregion
}
}