using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeTaskRequiredItems : IBehTreeTask
{
#region RED Properties

[REDProp("LeftItemType")]
public CName LeftItemType { get; set;}

[REDProp("RightItemType")]
public CName RightItemType { get; set;}

[REDProp("chooseSilverIfPossible")]
public bool ChooseSilverIfPossible { get; set;}

[REDProp("destroyProjectileOnDeactivate")]
public bool DestroyProjectileOnDeactivate { get; set;}

[REDProp("combatDataStorage")]
public Handle<CHumanAICombatStorage> CombatDataStorage { get; set;}

[REDProp("processLeftItem")]
public bool ProcessLeftItem { get; set;}

[REDProp("processRightItem")]
public bool ProcessRightItem { get; set;}

[REDProp("requiredItems")]
public bool RequiredItems { get; set;}

[REDProp("takeBowArrow")]
public bool TakeBowArrow { get; set;}

[REDProp("takeBolt")]
public bool TakeBolt { get; set;}

[REDProp("projResourceName")]
public string ProjResourceName { get; set;}

[REDProp("projEntity")]
public Handle<CEntityTemplate> ProjEntity { get; set;}

[REDProp("bolt")]
public Handle<W3AdvancedProjectile> Bolt { get; set;}

#endregion
}
}