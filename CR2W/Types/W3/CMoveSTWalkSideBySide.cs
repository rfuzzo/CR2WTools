using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTWalkSideBySide : IMoveSteeringTask
{
#region RED Properties

[REDProp("sideBySideDistance")]
public float SideBySideDistance { get; set;}

[REDProp("minApproachDistance")]
public float MinApproachDistance { get; set;}

[REDProp("maxApproachDistance")]
public float MaxApproachDistance { get; set;}

[REDProp("catchupSpeedMultiplier")]
public float CatchupSpeedMultiplier { get; set;}

[REDProp("slowDownSpeedMultiplier")]
public float SlowDownSpeedMultiplier { get; set;}

[REDProp("headingImportance")]
public float HeadingImportance { get; set;}

[REDProp("speedImportance")]
public float SpeedImportance { get; set;}

#endregion
}
}