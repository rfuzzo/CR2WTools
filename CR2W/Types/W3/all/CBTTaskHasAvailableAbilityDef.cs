using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHasAvailableAbilityDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("abilityName")]
public CName AbilityName { get; set;}

#endregion
}
}