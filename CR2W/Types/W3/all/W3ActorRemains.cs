using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ActorRemains : W3AnimatedContainer
{
#region RED Properties

[REDProp("dismemberOnLoot")]
public bool DismemberOnLoot { get; set;}

[REDProp("dismembermentOnlyWhenLootingTrophy")]
public bool DismembermentOnlyWhenLootingTrophy { get; set;}

[REDProp("dismembermentType")]
public EDismembermentWoundTypes DismembermentType { get; set;}

[REDProp("dismembermentName")]
public CName DismembermentName { get; set;}

[REDProp("manualTrophyTransfer")]
public bool ManualTrophyTransfer { get; set;}

[REDProp("owner")]
public Handle<CActor> Owner { get; set;}

[REDProp("hasTrophy")]
public bool HasTrophy { get; set;}

[REDProp("wasDismembered")]
public bool WasDismembered { get; set;}

[REDProp("trophyItemNames")]
public Array<CName> TrophyItemNames { get; set;}

#endregion
}
}