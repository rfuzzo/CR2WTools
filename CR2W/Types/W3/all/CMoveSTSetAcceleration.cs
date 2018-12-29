using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMoveSTSetAcceleration : IMoveSteeringTask
{
#region RED Properties

[REDProp("acceleration")]
public float Acceleration { get; set;}

[REDProp("deceleration")]
public float Deceleration { get; set;}

#endregion
}
}