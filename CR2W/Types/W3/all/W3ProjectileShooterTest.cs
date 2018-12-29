using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ProjectileShooterTest : CActor
{
#region RED Properties

[REDProp("projectileTemplate")]
public Handle<CEntityTemplate> ProjectileTemplate { get; set;}

[REDProp("targetTag")]
public CName TargetTag { get; set;}

[REDProp("frequency")]
public float Frequency { get; set;}

#endregion
}
}