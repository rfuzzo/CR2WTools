using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcReactionStopAndComment : CAINpcReaction
{
#region RED Properties

[REDProp("stopDuration")]
public float StopDuration { get; set;}

[REDProp("activationChance")]
public Int32 ActivationChance { get; set;}

[REDProp("distanceToInterrupt")]
public Int32 DistanceToInterrupt { get; set;}

#endregion
}
}