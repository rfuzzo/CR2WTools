using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3IllusionaryAppearance : W3IllusionaryObstacle
{
#region RED Properties

[REDProp("realAppearance")]
public string RealAppearance { get; set;}

#endregion
}
}