using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CFormationCatchupSlotSteeringTask : IFormationSteeringTask
{
#region RED Properties

[REDProp("speedImportance")]
public float SpeedImportance { get; set;}

[REDProp("toleranceDistance")]
public float ToleranceDistance { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("cachupSpeed")]
public float CachupSpeed { get; set;}

#endregion
}
}