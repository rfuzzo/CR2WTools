using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_ApplicatorOnHit : W3ApplicatorEffect
{
#region RED Properties

[REDProp("fromSilverSword")]
public bool FromSilverSword { get; set;}

[REDProp("fromSteelSword")]
public bool FromSteelSword { get; set;}

[REDProp("fromSign")]
public bool FromSign { get; set;}

[REDProp("fromAll")]
public bool FromAll { get; set;}

#endregion
}
}