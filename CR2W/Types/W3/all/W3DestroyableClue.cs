using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3DestroyableClue : W3MonsterClue
{
#region RED Properties

[REDProp("destroyable")]
public bool Destroyable { get; set;}

[REDProp("reactsToAard")]
public bool ReactsToAard { get; set;}

[REDProp("reactsToIgni")]
public bool ReactsToIgni { get; set;}

[REDProp("reactsToSwords")]
public bool ReactsToSwords { get; set;}

[REDProp("reactsToBolts")]
public bool ReactsToBolts { get; set;}

[REDProp("reactsToBombs")]
public bool ReactsToBombs { get; set;}

[REDProp("defaultEffect")]
public CName DefaultEffect { get; set;}

[REDProp("effectOnReaction")]
public CName EffectOnReaction { get; set;}

[REDProp("effectOnBurning")]
public CName EffectOnBurning { get; set;}

[REDProp("effectInstant")]
public bool EffectInstant { get; set;}

[REDProp("reactionDelay")]
public float ReactionDelay { get; set;}

[REDProp("onDestroyedFact")]
public Array<string> OnDestroyedFact { get; set;}

[REDProp("performDestructionSystemCheck")]
public bool PerformDestructionSystemCheck { get; set;}

[REDProp("isBurning")]
public bool IsBurning { get; set;}

[REDProp("destroyed")]
public bool Destroyed { get; set;}

#endregion
}
}