using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CWorld : CResource
{
#region RED Properties

[REDProp("startupCameraPosition")]
public Vector StartupCameraPosition { get; set;}

[REDProp("startupCameraRotation")]
public EulerAngles StartupCameraRotation { get; set;}

[REDProp("terrainClipMap")]
public Ptr<CClipMap> TerrainClipMap { get; set;}

[REDProp("newLayerGroupFormat")]
public bool NewLayerGroupFormat { get; set;}

[REDProp("hasEmbeddedLayerInfos")]
public bool HasEmbeddedLayerInfos { get; set;}

[REDProp("initialyHidenLayerGroups")]
public Handle<C2dArray> InitialyHidenLayerGroups { get; set;}

[REDProp("umbraScene")]
public Handle<CUmbraScene> UmbraScene { get; set;}

[REDProp("globalWater")]
public Ptr<CGlobalWater> GlobalWater { get; set;}

[REDProp("pathLib")]
public Ptr<CPathLibWorld> PathLib { get; set;}

[REDProp("worldDimensions")]
public float WorldDimensions { get; set;}

[REDProp("shadowConfig")]
public CWorldShadowConfig ShadowConfig { get; set;}

[REDProp("environmentParameters")]
public SWorldEnvironmentParameters EnvironmentParameters { get; set;}

[REDProp("soundBanksDependency")]
public Array<CName> SoundBanksDependency { get; set;}

[REDProp("soundEventsOnAttach")]
public Array<StringAnsi> SoundEventsOnAttach { get; set;}

[REDProp("soundEventsOnDetach")]
public Array<StringAnsi> SoundEventsOnDetach { get; set;}

[REDProp("foliageScene")]
public Ptr<CFoliageScene> FoliageScene { get; set;}

[REDProp("playGoChunks")]
public Array<CName> PlayGoChunks { get; set;}

[REDProp("minimapsPath")]
public string MinimapsPath { get; set;}

[REDProp("hubmapsPath")]
public string HubmapsPath { get; set;}

[REDProp("mergedGeometry")]
public Ptr<CMergedWorldGeometry> MergedGeometry { get; set;}

#endregion
}
}