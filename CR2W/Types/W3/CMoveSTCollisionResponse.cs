using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTCollisionResponse : IMoveSteeringTask
{
#region RED Properties

[REDProp("headingImportanceMin")]
public float HeadingImportanceMin { get; set;}

[REDProp("headingImportanceMax")]
public float HeadingImportanceMax { get; set;}

[REDProp("radiusMult")]
public float RadiusMult { get; set;}

#endregion
}
}