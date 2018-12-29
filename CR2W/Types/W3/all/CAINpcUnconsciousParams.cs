using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcUnconsciousParams : CAIDeathParameters
{
#region RED Properties

[REDProp("unconsciousDuration")]
public float UnconsciousDuration { get; set;}

[REDProp("unconsciousGetUpDist")]
public float UnconsciousGetUpDist { get; set;}

#endregion
}
}