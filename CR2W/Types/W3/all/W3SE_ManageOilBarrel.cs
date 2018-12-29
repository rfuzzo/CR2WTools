using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_ManageOilBarrel : W3SwitchEvent
{
#region RED Properties

[REDProp("oilBarrelTag")]
public CName OilBarrelTag { get; set;}

[REDProp("operations")]
public Array<EOilBarrelOperation> Operations { get; set;}

#endregion
}
}