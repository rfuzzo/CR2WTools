using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskTackleDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("dealDamage")]
public bool DealDamage { get; set;}

[REDProp("activeOnAnimEvent")]
public bool ActiveOnAnimEvent { get; set;}

#endregion
}
}