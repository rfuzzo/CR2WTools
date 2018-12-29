using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SSweepHitResult 
{
#region RED Properties

[REDProp("position")]
public Vector Position { get; set;}

[REDProp("normal")]
public Vector Normal { get; set;}

[REDProp("distance")]
public float Distance { get; set;}

[REDProp("component")]
public Handle<CComponent> Component { get; set;}

#endregion
}
}