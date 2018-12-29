using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCombatStorage : IBehTreeTask
{
#region RED Properties

[REDProp("combatDataStorage")]
public Handle<CBaseAICombatStorage> CombatDataStorage { get; set;}

[REDProp("setIsShooting")]
public bool SetIsShooting { get; set;}

[REDProp("setIsAiming")]
public bool SetIsAiming { get; set;}

#endregion
}
}