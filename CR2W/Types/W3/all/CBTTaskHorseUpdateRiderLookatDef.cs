using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHorseUpdateRiderLookatDef : IBehTreeHorseTaskDefinition
{
#region RED Properties

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("useCustomTarget")]
public bool UseCustomTarget { get; set;}

[REDProp("boneName")]
public CName BoneName { get; set;}

#endregion
}
}