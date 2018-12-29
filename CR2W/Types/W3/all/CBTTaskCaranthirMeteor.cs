using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCaranthirMeteor : CBTTaskProjectileAttack
{
#region RED Properties

[REDProp("riftResourceName")]
public CName RiftResourceName { get; set;}

[REDProp("targetPos")]
public Vector TargetPos { get; set;}

#endregion
}
}