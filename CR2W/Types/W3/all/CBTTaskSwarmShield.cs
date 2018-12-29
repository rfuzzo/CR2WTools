using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSwarmShield : CBTTaskPlayAnimationEventDecorator
{
#region RED Properties

[REDProp("lair")]
public Handle<CFlyingSwarmMasterLair> Lair { get; set;}

[REDProp("stabilizationTimer")]
public float StabilizationTimer { get; set;}

[REDProp("disperse")]
public bool Disperse { get; set;}

#endregion
}
}