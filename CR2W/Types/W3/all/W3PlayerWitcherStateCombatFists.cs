using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PlayerWitcherStateCombatFists : CR4PlayerStateCombat
{
#region RED Properties

[REDProp("action")]
public SInputAction Action { get; set;}

#endregion
}
}