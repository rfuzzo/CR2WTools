using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CSStoryPhaseSpawnTimetableEntry 
{
#region RED Properties

[REDProp("time")]
public GameTime Time { get; set;}

[REDProp("quantity")]
public int Quantity { get; set;}

[REDProp("respawnDelay")]
public GameTime RespawnDelay { get; set;}

[REDProp("respawn")]
public bool Respawn { get; set;}

#endregion
}
}