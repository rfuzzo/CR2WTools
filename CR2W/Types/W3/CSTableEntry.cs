using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CSTableEntry 
{
#region RED Properties

[REDProp("comment")]
public string Comment { get; set;}

[REDProp("entryID")]
public string EntryID { get; set;}

[REDProp("entities")]
public Array<CSEntitiesEntry> Entities { get; set;}

[REDProp("alwaysSpawned")]
public bool AlwaysSpawned { get; set;}

[REDProp("storyPhases")]
public Array<CSStoryPhaseEntry> StoryPhases { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

#endregion
}
}