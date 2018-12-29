using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CAIMinigameParamsWristWrestling : CObject
{
#region RED Properties

[REDProp("hotSpotMinWidth")]
public int HotSpotMinWidth { get; set;}

[REDProp("hotSpotMaxWidth")]
public int HotSpotMaxWidth { get; set;}

[REDProp("gameDifficulty")]
public EAIMinigameDifficulty GameDifficulty { get; set;}

#endregion
}
}