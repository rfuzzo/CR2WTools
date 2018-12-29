using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskChangeAppearanceDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("appearanceName")]
public CName AppearanceName { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDectivate")]
public bool OnDectivate { get; set;}

[REDProp("onAnimEvent")]
public CName OnAnimEvent { get; set;}

#endregion
}
}