using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIStorageReactionData : IScriptable
{
#region RED Properties

[REDProp("TAUNTS_TO_BE_ALARMED")]
public Int32 TAUNTS_TO_BE_ALARMED { get; set;}

[REDProp("alarmedTimeStamp")]
public float AlarmedTimeStamp { get; set;}

[REDProp("tauntCounter")]
public Int32 TauntCounter { get; set;}

[REDProp("lastTauntTimeStamp")]
public float LastTauntTimeStamp { get; set;}

[REDProp("temporaryHostileActors")]
public Array<Handle<CActor>> TemporaryHostileActors { get; set;}

#endregion
}
}