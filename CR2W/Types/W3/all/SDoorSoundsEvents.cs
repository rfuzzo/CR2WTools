using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SDoorSoundsEvents 
{
#region RED Properties

[REDProp("open")]
public string Open { get; set;}

[REDProp("openFully")]
public string OpenFully { get; set;}

[REDProp("openingStart")]
public string OpeningStart { get; set;}

[REDProp("openingStop")]
public string OpeningStop { get; set;}

[REDProp("close")]
public string Close { get; set;}

[REDProp("closeFully")]
public string CloseFully { get; set;}

[REDProp("closingStart")]
public string ClosingStart { get; set;}

[REDProp("closingStop")]
public string ClosingStop { get; set;}

#endregion
}
}