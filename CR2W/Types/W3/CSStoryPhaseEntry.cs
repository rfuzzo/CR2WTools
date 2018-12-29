using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CSStoryPhaseEntry 
{
#region RED Properties

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("comment")]
public string Comment { get; set;}

[REDProp("storyPhaseName")]
public CSStoryPhaseNames StoryPhaseName { get; set;}

[REDProp("isHiddenSpawn")]
public bool IsHiddenSpawn { get; set;}

[REDProp("initializers")]
public Ptr<CCommunityInitializers> Initializers { get; set;}

[REDProp("spawnTimetable")]
public Array<CSStoryPhaseSpawnTimetableEntry> SpawnTimetable { get; set;}

[REDProp("timetableName")]
public CName TimetableName { get; set;}

[REDProp("spawnDelay")]
public GameTime SpawnDelay { get; set;}

[REDProp("spawnPointTags")]
public TagList SpawnPointTags { get; set;}

[REDProp("despawnPointTags")]
public TagList DespawnPointTags { get; set;}

[REDProp("startInAP")]
public bool StartInAP { get; set;}

[REDProp("useLastAP")]
public bool UseLastAP { get; set;}

[REDProp("alwaysSpawned")]
public bool AlwaysSpawned { get; set;}

[REDProp("spawnStrategy")]
public Ptr<CCommunitySpawnStrategy> SpawnStrategy { get; set;}

[REDProp("cachedMapPinPosition")]
public Vector CachedMapPinPosition { get; set;}

#endregion
}
}