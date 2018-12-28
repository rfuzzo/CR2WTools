using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class TCrPropertySet : CObject
{
#region RED Properties

[REDProp("shoulderWeight")]
public float ShoulderWeight { get; set;}

[REDProp("shoulderLimitUpDeg")]
public float ShoulderLimitUpDeg { get; set;}

[REDProp("shoulderLimitDownDeg")]
public float ShoulderLimitDownDeg { get; set;}

[REDProp("shoulderLimitLeftDeg")]
public float ShoulderLimitLeftDeg { get; set;}

[REDProp("shoulderLimitRightDeg")]
public float ShoulderLimitRightDeg { get; set;}

#endregion
}
}