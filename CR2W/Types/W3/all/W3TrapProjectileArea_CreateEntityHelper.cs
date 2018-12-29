using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TrapProjectileArea_CreateEntityHelper : CCreateEntityHelper
{
#region RED Properties

[REDProp("owner")]
public Handle<W3TrapProjectileArea> Owner { get; set;}

[REDProp("velocity")]
public float Velocity { get; set;}

[REDProp("targetPos")]
public Vector TargetPos { get; set;}

#endregion
}
}