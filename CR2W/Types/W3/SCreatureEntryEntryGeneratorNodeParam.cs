using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SCreatureEntryEntryGeneratorNodeParam 
{
#region RED Properties

[REDProp("comment")]
public string Comment { get; set;}

[REDProp("qualityMin")]
public int QualityMin { get; set;}

[REDProp("qualityMax")]
public int QualityMax { get; set;}

[REDProp("spawnWayPointTag")]
public TagList SpawnWayPointTag { get; set;}

[REDProp("creatureDefinition")]
public SCreatureDefinitionWrapper CreatureDefinition { get; set;}

[REDProp("appearanceName")]
public CName AppearanceName { get; set;}

[REDProp("tagToAssign")]
public CName TagToAssign { get; set;}

[REDProp("group")]
public int Group { get; set;}

#endregion
}
}