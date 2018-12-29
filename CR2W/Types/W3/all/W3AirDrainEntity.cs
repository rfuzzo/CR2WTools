using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3AirDrainEntity : CGameplayEntity
{
#region RED Properties

[REDProp("customDrainPoints")]
public float CustomDrainPoints { get; set;}

[REDProp("customDrainPercents")]
public float CustomDrainPercents { get; set;}

[REDProp("factOnActivated")]
public string FactOnActivated { get; set;}

[REDProp("factOnDeactivated")]
public string FactOnDeactivated { get; set;}

#endregion
}
}