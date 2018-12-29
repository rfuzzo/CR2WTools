using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class Crossbow : RangedWeapon
{
#region RED Properties

[REDProp("shotCount")]
public Int32 ShotCount { get; set;}

[REDProp("shotCountLimit")]
public Int32 ShotCountLimit { get; set;}

[REDProp("reloadAtStartComplete")]
public bool ReloadAtStartComplete { get; set;}

#endregion
}
}