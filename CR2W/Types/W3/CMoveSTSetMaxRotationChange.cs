using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTSetMaxRotationChange : IMoveSteeringTask
{
#region RED Properties

[REDProp("angle")]
public float Angle { get; set;}

#endregion
}
}