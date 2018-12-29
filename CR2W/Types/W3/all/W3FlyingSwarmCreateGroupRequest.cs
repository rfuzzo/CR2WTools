using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3FlyingSwarmCreateGroupRequest : CObject
{
#region RED Properties

[REDProp("boidCount")]
public Int32 BoidCount { get; set;}

[REDProp("spawnPOI")]
public CName SpawnPOI { get; set;}

#endregion
}
}