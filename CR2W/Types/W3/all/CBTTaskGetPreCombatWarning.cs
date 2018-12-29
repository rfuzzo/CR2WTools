using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskGetPreCombatWarning : IBehTreeTask
{
#region RED Properties

[REDProp("combatDataStorage")]
public Handle<CBaseAICombatStorage> CombatDataStorage { get; set;}

[REDProp("setFlagOnActivate")]
public bool SetFlagOnActivate { get; set;}

[REDProp("setFlagOnDectivate")]
public bool SetFlagOnDectivate { get; set;}

[REDProp("flag")]
public bool Flag { get; set;}

#endregion
}
}