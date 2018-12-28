using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTSnapToMinimalVelocity : IMoveSteeringTask
{
#region RED Properties

[REDProp("minVelocity")]
public float MinVelocity { get; set;}

#endregion
}
}