using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CR4WorldDescriptionDLC : CObject
{
#region RED Properties

[REDProp("worldEnumAreaName")]
public CName WorldEnumAreaName { get; set;}

[REDProp("worldName")]
public string WorldName { get; set;}

[REDProp("worldMapPath")]
public string WorldMapPath { get; set;}

[REDProp("worldMapPinX")]
public int WorldMapPinX { get; set;}

[REDProp("worldMapPinY")]
public int WorldMapPinY { get; set;}

[REDProp("worldMapLoactionNameStringKey")]
public CName WorldMapLoactionNameStringKey { get; set;}

[REDProp("worldMapLoactionDescriptionStringKey")]
public CName WorldMapLoactionDescriptionStringKey { get; set;}

[REDProp("requiredChunk")]
public CName RequiredChunk { get; set;}

[REDProp("worldMiniMapSize")]
public float WorldMiniMapSize { get; set;}

[REDProp("worldMiniMapTileCount")]
public int WorldMiniMapTileCount { get; set;}

[REDProp("worldMiniMapExteriorTextureSize")]
public int WorldMiniMapExteriorTextureSize { get; set;}

[REDProp("worldMiniMapInteriorTextureSize")]
public int WorldMiniMapInteriorTextureSize { get; set;}

[REDProp("worldMiniMapTextureSize")]
public int WorldMiniMapTextureSize { get; set;}

[REDProp("worldMiniMapMinLod")]
public int WorldMiniMapMinLod { get; set;}

[REDProp("worldMiniMapMaxLod")]
public int WorldMiniMapMaxLod { get; set;}

[REDProp("worldMiniMapExteriorTextureExtension")]
public string WorldMiniMapExteriorTextureExtension { get; set;}

[REDProp("worldMiniMapInteriorTextureExtension")]
public string WorldMiniMapInteriorTextureExtension { get; set;}

[REDProp("worldMiniMapVminX")]
public int WorldMiniMapVminX { get; set;}

[REDProp("worldMiniMapVmaxX")]
public int WorldMiniMapVmaxX { get; set;}

[REDProp("worldMiniMapVminY")]
public int WorldMiniMapVminY { get; set;}

[REDProp("worldMiniMapVmaxY")]
public int WorldMiniMapVmaxY { get; set;}

[REDProp("worldMiniMapSminX")]
public int WorldMiniMapSminX { get; set;}

[REDProp("worldMiniMapSmaxX")]
public int WorldMiniMapSmaxX { get; set;}

[REDProp("worldMiniMapSminY")]
public int WorldMiniMapSminY { get; set;}

[REDProp("worldMiniMapSmaxY")]
public int WorldMiniMapSmaxY { get; set;}

[REDProp("worldMiniMapMinZoom")]
public float WorldMiniMapMinZoom { get; set;}

[REDProp("worldMiniMapMaxZoom")]
public float WorldMiniMapMaxZoom { get; set;}

[REDProp("worldMiniMapZoom12")]
public float WorldMiniMapZoom12 { get; set;}

[REDProp("worldMiniMapZoom23")]
public float WorldMiniMapZoom23 { get; set;}

[REDProp("worldMiniMapZoom34")]
public float WorldMiniMapZoom34 { get; set;}

[REDProp("worldGradientScale")]
public float WorldGradientScale { get; set;}

[REDProp("worldPreviewHeight")]
public float WorldPreviewHeight { get; set;}

#endregion
}
}