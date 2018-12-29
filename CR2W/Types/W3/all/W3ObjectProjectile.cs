using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ObjectProjectile : CProjectileTrajectory
{
#region RED Properties

[REDProp("action")]
public Handle<W3DamageAction> Action { get; set;}

[REDProp("owner")]
public Handle<CActor> Owner { get; set;}

#endregion
}
}