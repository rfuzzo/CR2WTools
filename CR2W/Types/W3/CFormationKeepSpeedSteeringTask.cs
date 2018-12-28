using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CFormationKeepSpeedSteeringTask : IFormationSteeringTask
{
#region RED Properties

[REDProp("speedImportance")]
public float SpeedImportance { get; set;}

#endregion
}
}