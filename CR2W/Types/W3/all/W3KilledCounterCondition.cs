using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3KilledCounterCondition : ISpawnScriptCondition
{
#region RED Properties

[REDProp("killedValue")]
public Int32 KilledValue { get; set;}

[REDProp("operator")]
public EOperator Operator { get; set;}

[REDProp("killedCreatures")]
public Int32 KilledCreatures { get; set;}

[REDProp("dataManager")]
public Handle<CEncounterDataManager> DataManager { get; set;}

#endregion
}
}