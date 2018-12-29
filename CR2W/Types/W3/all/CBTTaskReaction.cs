using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskReaction : IBehTreeTask
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

[REDProp("Time2Dodge")]
public bool Time2Dodge { get; set;}

[REDProp("dodgeType")]
public EDodgeType DodgeType { get; set;}

[REDProp("nextReactionTime")]
public float NextReactionTime { get; set;}

[REDProp("reactionDelay")]
public float ReactionDelay { get; set;}

#endregion
}
}