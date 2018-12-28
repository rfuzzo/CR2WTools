using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSSceneTimetableEntry 
{
#region RED Properties

[REDProp("time")]
public GameTimeInterval Time { get; set;}

[REDProp("scenes")]
public Array<CSSceneTimetableScenesEntry> Scenes { get; set;}

#endregion
}
}