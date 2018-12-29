using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMoveToPointParams : IAIActionParameters
{
#region RED Properties

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("moveSpeed")]
public float MoveSpeed { get; set;}

[REDProp("moveType")]
public EMoveType MoveType { get; set;}

[REDProp("destinationPosition")]
public Vector DestinationPosition { get; set;}

[REDProp("destinationHeading")]
public float DestinationHeading { get; set;}

[REDProp("maxIterationsNumber")]
public Int32 MaxIterationsNumber { get; set;}

[REDProp("useTimeout")]
public bool UseTimeout { get; set;}

[REDProp("timeoutValue")]
public float TimeoutValue { get; set;}

#endregion
}
}