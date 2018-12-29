using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CFormationSteerToSlotSteeringTask : IFormationFragmentarySteeringTask
{
#region RED Properties

[REDProp("importance")]
public float Importance { get; set;}

[REDProp("speedImportance")]
public float SpeedImportance { get; set;}

#endregion
}
}