using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3POIDispenser : CGameplayEntity
{
#region RED Properties

[REDProp("pointsTag")]
public CName PointsTag { get; set;}

[REDProp("onExitDespawnAllAfter")]
public Int32 OnExitDespawnAllAfter { get; set;}

[REDProp("shouldUseRandomRespawnTime")]
public bool ShouldUseRandomRespawnTime { get; set;}

[REDProp("respawnInterval")]
public float RespawnInterval { get; set;}

[REDProp("poiEntity")]
public W3POIEntities PoiEntity { get; set;}

[REDProp("spawnedPOIs")]
public Array<Handle<W3PointOfInterestEntity>> SpawnedPOIs { get; set;}

[REDProp("activatorArea")]
public Handle<CTriggerAreaComponent> ActivatorArea { get; set;}

#endregion
}
}