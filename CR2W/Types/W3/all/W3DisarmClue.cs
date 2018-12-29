using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3DisarmClue : W3MonsterClue
{
#region RED Properties

[REDProp("connectedTripwireTag")]
public CName ConnectedTripwireTag { get; set;}

[REDProp("connectedTripwire")]
public Handle<W3TripwireSwitch> ConnectedTripwire { get; set;}

#endregion
}
}