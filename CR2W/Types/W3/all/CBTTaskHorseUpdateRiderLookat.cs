using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHorseUpdateRiderLookat : IBehTreeTask
{
#region RED Properties

[REDProp("rider")]
public Handle<CActor> Rider { get; set;}

[REDProp("boneName")]
public CName BoneName { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("useCustomTarget")]
public bool UseCustomTarget { get; set;}

#endregion
}
}