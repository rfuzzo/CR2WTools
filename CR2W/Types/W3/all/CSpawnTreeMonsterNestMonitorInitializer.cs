using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSpawnTreeMonsterNestMonitorInitializer : ISpawnTreeSpawnMonitorInitializer
{
#region RED Properties

[REDProp("monsterNestTag")]
public CName MonsterNestTag { get; set;}

[REDProp("disableRebuildingOnBossDeath")]
public bool DisableRebuildingOnBossDeath { get; set;}

#endregion
}
}