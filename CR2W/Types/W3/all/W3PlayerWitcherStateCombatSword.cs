using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PlayerWitcherStateCombatSword : CR4PlayerStateCombat
{
#region RED Properties

[REDProp("bIsInPirouette")]
public bool BIsInPirouette { get; set;}

[REDProp("swordId")]
public SItemUniqueId SwordId { get; set;}

#endregion
}
}