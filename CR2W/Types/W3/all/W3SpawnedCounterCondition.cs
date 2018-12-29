using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SpawnedCounterCondition : ISpawnScriptCondition
{
#region RED Properties

[REDProp("spawnedValue")]
public Int32 SpawnedValue { get; set;}

[REDProp("operator")]
public EOperator Operator { get; set;}

[REDProp("spawnedCreatures")]
public Int32 SpawnedCreatures { get; set;}

[REDProp("dataManager")]
public Handle<CEncounterDataManager> DataManager { get; set;}

#endregion
}
}