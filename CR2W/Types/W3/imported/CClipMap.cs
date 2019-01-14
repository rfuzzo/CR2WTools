using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CClipMap : CObject
{
#region RED Properties

[REDProp("clipSize")]
public UInt32 ClipSize { get; set;}

[REDProp("clipmapSize")]
public UInt32 ClipmapSize { get; set;}

[REDProp("numClipmapStackLevels")]
public UInt32 NumClipmapStackLevels { get; set;}

[REDProp("tileRes")]
public UInt32 TileRes { get; set;}

[REDProp("colormapStartingMip")]
public Int32 ColormapStartingMip { get; set;}

[REDProp("terrainSize")]
public float TerrainSize { get; set;}

[REDProp("terrainCorner")]
public Vector TerrainCorner { get; set;}

[REDProp("numTilesPerEdge")]
public UInt32 NumTilesPerEdge { get; set;}

[REDProp("lowestElevation")]
public float LowestElevation { get; set;}

[REDProp("highestElevation")]
public float HighestElevation { get; set;}

[REDProp("material")]
public Handle<IMaterial> Material { get; set;}

[REDProp("textureParams", 2,0)]
public Array<STerrainTextureParameters> TextureParams { get; set;}

[REDProp("grassBrushes", 2,0)]
public Array<Handle<CVegetationBrush>> GrassBrushes { get; set;}

[REDProp("tileHeightRanges", 2,0,2)]
public Array<Vector2> TileHeightRanges { get; set;}

[REDProp("minWaterHeight", 2,0)]
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