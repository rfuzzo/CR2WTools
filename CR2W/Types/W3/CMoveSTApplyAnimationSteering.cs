using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTApplyAnimationSteering : CMoveSTApplySteering
{
#region RED Properties

[REDProp("minSpeed")]
public float MinSpeed { get; set;}

[REDProp("rotationVar")]
public CName RotationVar { get; set;}

#endregion
}
}