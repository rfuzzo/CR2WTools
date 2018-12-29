using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3AirDrainArea : CGameplayEntity
{
#region RED Properties

[REDProp("customDrainPoints")]
public float CustomDrainPoints { get; set;}

[REDProp("customDrainPercents")]
public float CustomDrainPercents { get; set;}

#endregion
}
}