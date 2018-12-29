using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ExplosiveBolt : W3BoltProjectile
{
#region RED Properties

[REDProp("explosionRange")]
public float ExplosionRange { get; set;}

[REDProp("insideToxicClouds")]
public Array<Handle<W3ToxicCloud>> InsideToxicClouds { get; set;}

#endregion
}
}