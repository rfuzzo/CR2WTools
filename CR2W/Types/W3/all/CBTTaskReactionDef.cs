using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskReactionDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("counterChance")]
public Int32 CounterChance { get; set;}

[REDProp("dodgeChanceAttacks")]
public Int32 DodgeChanceAttacks { get; set;}

[REDProp("dodgeChanceAard")]
public Int32 DodgeChanceAard { get; set;}

[REDProp("dodgeChanceIgni")]
public Int32 DodgeChanceIgni { get; set;}

[REDProp("dodgeChanceBomb")]
public Int32 DodgeChanceBomb { get; set;}

[REDProp("dodgeChanceProjectile")]
public Int32 DodgeChanceProjectile { get; set;}

[REDProp("reactionDelay")]
public float ReactionDelay { get; set;}

#endregion
}
}