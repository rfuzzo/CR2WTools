using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCombatStorageDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("setIsShooting")]
public bool SetIsShooting { get; set;}

[REDProp("setIsAiming")]
public bool SetIsAiming { get; set;}

#endregion
}
}