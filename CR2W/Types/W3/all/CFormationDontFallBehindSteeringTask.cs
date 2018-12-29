using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFormationDontFallBehindSteeringTask : IFormationSteeringTask
{
#region RED Properties

[REDProp("speedImportance")]
public float SpeedImportance { get; set;}

[REDProp("minFallBehindDistance")]
public float MinFallBehindDistance { get; set;}

[REDProp("maxFallBehindDistance")]
public float MaxFallBehindDistance { get; set;}

#endregion
}
}