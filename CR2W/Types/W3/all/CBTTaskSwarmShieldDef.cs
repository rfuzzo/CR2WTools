using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSwarmShieldDef : CBTTaskPlayAnimationEventDecoratorDef
{
#region RED Properties

[REDProp("stabilizationTimer")]
public float StabilizationTimer { get; set;}

[REDProp("disperse")]
public bool Disperse { get; set;}

#endregion
}
}