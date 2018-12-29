using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SActionPointId 
{
#region RED Properties

[REDProp("component")]
public CGUID Component { get; set;}

[REDProp("entity")]
public CGUID Entity { get; set;}

#endregion
}
}