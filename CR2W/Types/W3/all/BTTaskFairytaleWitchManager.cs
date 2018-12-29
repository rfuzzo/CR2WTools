using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskFairytaleWitchManager : IBehTreeTask
{
#region RED Properties

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("spawnedNpc")]
public Handle<CNewNPC> SpawnedNpc { get; set;}

[REDProp("spawnedSecondNpc")]
public Handle<CNewNPC> SpawnedSecondNpc { get; set;}

[REDProp("nodeTags")]
public Array<CName> NodeTags { get; set;}

[REDProp("resourceName")]
public Array<CName> ResourceName { get; set;}

[REDProp("initialSleepTime")]
public float InitialSleepTime { get; set;}

[REDProp("firstNodeTag")]
public CName FirstNodeTag { get; set;}

[REDProp("secondNodeTag")]
public CName SecondNodeTag { get; set;}

[REDProp("thirdNodeTag")]
public CName ThirdNodeTag { get; set;}

[REDProp("finalNodeTag")]
public CName FinalNodeTag { get; set;}

[REDProp("archesporResource")]
public CName ArchesporResource { get; set;}

[REDProp("pantherResource")]
public CName PantherResource { get; set;}

#endregion
}
}