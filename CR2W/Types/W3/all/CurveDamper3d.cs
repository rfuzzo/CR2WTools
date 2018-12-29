using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CurveDamper3d : CObject
{
#region RED Properties

[REDProp("damperX")]
public Handle<CurveDamper> DamperX { get; set;}

[REDProp("damperY")]
public Handle<CurveDamper> DamperY { get; set;}

[REDProp("damperZ")]
public Handle<CurveDamper> DamperZ { get; set;}

#endregion
}
}