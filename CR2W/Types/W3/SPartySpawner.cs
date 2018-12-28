using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SPartySpawner 
{
#region RED Properties

[REDProp("firstIndex")]
public uint FirstIndex { get; set;}

[REDProp("waypointsCount")]
public uint WaypointsCount { get; set;}

[REDProp("mappingIndex")]
public uint MappingIndex { get; set;}

#endregion
}
}