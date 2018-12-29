using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SEntityMapPinInfo 
{
#region RED Properties

[REDProp("entityName")]
public CName EntityName { get; set;}

[REDProp("entityCustomNameId")]
public uint EntityCustomNameId { get; set;}

[REDProp("entityTags")]
public TagList EntityTags { get; set;}

[REDProp("entityPosition")]
public Vector EntityPosition { get; set;}

[REDProp("entityRadius")]
public float EntityRadius { get; set;}

[REDProp("entityType")]
public CName EntityType { get; set;}

[REDProp("alternateVersion")]
public int AlternateVersion { get; set;}

[REDProp("fastTravelSpotName")]
public CName FastTravelSpotName { get; set;}

[REDProp("fastTravelGroupName")]
public CName FastTravelGroupName { get; set;}

[REDProp("fastTravelTeleportWayPointTag")]
public CName FastTravelTeleportWayPointTag { get; set;}

[REDProp("fastTravelTeleportWayPointPosition")]
public Vector FastTravelTeleportWayPointPosition { get; set;}

[REDProp("fastTravelTeleportWayPointRotation")]
public EulerAngles FastTravelTeleportWayPointRotation { get; set;}

#endregion
}
}