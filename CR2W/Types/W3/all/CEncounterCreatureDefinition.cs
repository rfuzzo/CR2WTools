using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEncounterCreatureDefinition : CObject
{
#region RED Properties

[REDProp("definitionName")]
public CName DefinitionName { get; set;}

[REDProp("entityTemplate")]
public Soft<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("totalSpawnLimit")]
public UInt16 TotalSpawnLimit { get; set;}

[REDProp("maxSpawnedAtOnce")]
public UInt16 MaxSpawnedAtOnce { get; set;}

[REDProp("override")]
public bool Override { get; set;}

[REDProp("forcedAppearance")]
public CName ForcedAppearance { get; set;}

[REDProp("tags")]
public TagList Tags { get; set;}

#endregion
}
}