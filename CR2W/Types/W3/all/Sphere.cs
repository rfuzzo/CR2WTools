using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class Sphere 
{
#region RED Properties

[REDProp("CenterRadius2")]
public Vector CenterRadius2 { get; set;}

#endregion
}
}