using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SWanderPointConnection 
{
#region RED Properties

[REDProp("destination")]
public EntityHandle Destination { get; set;}

[REDProp("forcePathfinding")]
public bool ForcePathfinding { get; set;}

#endregion
}
}