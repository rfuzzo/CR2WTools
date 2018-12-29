using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskChangeAltitudeDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onMain")]
public bool OnMain { get; set;}

[REDProp("HighFlightChance")]
public float HighFlightChance { get; set;}

[REDProp("LowFlightChance")]
public float LowFlightChance { get; set;}

[REDProp("LandChance")]
public float LandChance { get; set;}

[REDProp("frequency")]
public float Frequency { get; set;}

#endregion
}
}