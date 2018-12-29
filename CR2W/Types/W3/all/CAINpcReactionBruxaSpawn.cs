using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcReactionBruxaSpawn : CAINpcReaction
{
#region RED Properties

[REDProp("activationChance")]
public Int32 ActivationChance { get; set;}

[REDProp("distanceToInterrupt")]
public Int32 DistanceToInterrupt { get; set;}

#endregion
}
}