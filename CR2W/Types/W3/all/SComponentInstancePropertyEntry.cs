using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SComponentInstancePropertyEntry 
{
#region RED Properties

[REDProp("component")]
public CName Component { get; set;}

[REDProp("property")]
public CName Property { get; set;}

#endregion
}
}