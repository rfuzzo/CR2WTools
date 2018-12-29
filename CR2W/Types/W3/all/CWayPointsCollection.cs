using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CWayPointsCollection : CResource
{
#region RED Properties

[REDProp("version")]
public UInt16 Version { get; set;}

[REDProp("waypointsCount")]
public UInt16 WaypointsCount { get; set;}

[REDProp("componentsMappingsCount")]
public UInt16 ComponentsMappingsCount { get; set;}

[REDProp("waypointsGroupsCount")]
public UInt16 WaypointsGroupsCount { get; set;}

[REDProp("indexesCount")]
public uint IndexesCount { get; set;}

[REDProp("parties")]
public Array<SPartySpawner> Parties { get; set;}

[REDProp("partyWaypoints")]
public Array<SPartyWaypointData> PartyWaypoints { get; set;}

#endregion
}
}