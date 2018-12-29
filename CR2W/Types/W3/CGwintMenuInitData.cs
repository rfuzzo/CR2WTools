using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CGwintMenuInitData : CObject
{
#region RED Properties

[REDProp("deckName")]
public CName DeckName { get; set;}

[REDProp("difficulty")]
public EGwintDifficultyMode Difficulty { get; set;}

[REDProp("aggression")]
public EGwintAggressionMode Aggression { get; set;}

[REDProp("allowMultipleMatches")]
public bool AllowMultipleMatches { get; set;}

[REDProp("forceFaction")]
public eGwintFaction ForceFaction { get; set;}

#endregion
}
}