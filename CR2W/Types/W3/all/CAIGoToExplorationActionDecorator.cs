using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIGoToExplorationActionDecorator : IActionDecorator
{
#region RED Properties

[REDProp("sheathWeaponsOnStart")]
public bool SheathWeaponsOnStart { get; set;}

#endregion
}
}