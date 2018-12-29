using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MagicalThing : CProjectileTrajectory
{
#region RED Properties

[REDProp("dmg")]
public float Dmg { get; set;}

#endregion
}
}