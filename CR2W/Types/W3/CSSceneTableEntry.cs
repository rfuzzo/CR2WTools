using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CSSceneTableEntry 
{
#region RED Properties

[REDProp("storyPhaseName")]
public CSStoryPhaseNames StoryPhaseName { get; set;}

[REDProp("cooldownTime")]
public float CooldownTime { get; set;}

[REDProp("timetable")]
public Array<CSSceneTimetableEntry> Timetable { get; set;}

#endregion
}
}