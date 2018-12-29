using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CClipMap : CObject
{
#region RED Properties

[REDProp("clipSize")]
public uint ClipSize { get; set;}

[REDProp("clipmapSize")]
public uint ClipmapSize { get; set;}

[REDProp("numClipmapStackLevels")]
public uint NumClipmapStackLevels { get; set;}

[REDProp("tileRes")]
public uint TileRes { get; set;}

[REDProp("colormapStartingMip")]
public int ColormapStartingMip { get; set;}

[REDProp("terrainSize")]
public float TerrainSize { get; set;}

[REDProp("terrainCorner")]
public Vector TerrainCorner { get; set;}

[REDProp("numTilesPerEdge")]
public uint NumTilesPerEdge { get; set;}

[REDProp("lowestElevation")]
public float LowestElevation { get; set;}

[REDProp("highestElevation")]
public float HighestElevation { get; set;}

[REDProp("material")]
public Handle<IMaterial> Material { get; set;}

[REDProp("textureParams")]
public Array<STerrainTextureParameters> TextureParams { get; set;}

[REDProp("grassBrushes")]
public Array<Handle<CVegetationBrush>> GrassBrushes { get; set;}

[REDProp("tileHeightRanges")]
public Array<Vector2> TileHeightRanges { get; set;}

[REDProp("minWaterHeight")]
public Array<float> MinWaterHeight { get; set;}

[REDProp("cookedMipStackHeight")]
public DataBuffer CookedMipStackHeight { get; set;}

[REDProp("cookedMipStackControl")]
public DataBuffer CookedMipStackControl { get; set;}

[REDProp("cookedMipStackColor")]
public DataBuffer CookedMipStackColor { get; set;}

[REDProp("cookedData")]
public Ptr<CClipMapCookedData> CookedData { get; set;}

#endregion
}
}