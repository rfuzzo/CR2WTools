using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CFistfightMinigame : CMinigame
{
#region RED Properties

[REDProp("fightAreaTag")]
public CName FightAreaTag { get; set;}

[REDProp("playerPosTag")]
public CName PlayerPosTag { get; set;}

[REDProp("toTheDeath")]
public bool ToTheDeath { get; set;}

[REDProp("endsWithBlackscreen")]
public bool EndsWithBlackscreen { get; set;}

[REDProp("enemies")]
public Array<CFistfightOpponent> Enemies { get; set;}

#endregion
}
}