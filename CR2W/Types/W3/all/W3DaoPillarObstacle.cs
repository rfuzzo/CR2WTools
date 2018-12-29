using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3DaoPillarObstacle : W3DurationObstacle
{
#region RED Properties

[REDProp("damageValue")]
public float DamageValue { get; set;}

#endregion
}
}