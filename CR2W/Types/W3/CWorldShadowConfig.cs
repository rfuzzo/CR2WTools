using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CWorldShadowConfig 
{
#region RED Properties

[REDProp("numCascades")]
public int NumCascades { get; set;}

[REDProp("cascadeRange1")]
public float CascadeRange1 { get; set;}

[REDProp("cascadeRange2")]
public float CascadeRange2 { get; set;}

[REDProp("cascadeRange3")]
public float CascadeRange3 { get; set;}

[REDProp("cascadeRange4")]
public float CascadeRange4 { get; set;}

[REDProp("cascadeFilterSize1")]
public float CascadeFilterSize1 { get; set;}

[REDProp("cascadeFilterSize2")]
public float CascadeFilterSize2 { get; set;}

[REDProp("cascadeFilterSize3")]
public float CascadeFilterSize3 { get; set;}

[REDProp("cascadeFilterSize4")]
public float CascadeFilterSize4 { get; set;}

[REDProp("shadowEdgeFade1")]
public float ShadowEdgeFade1 { get; set;}

[REDProp("shadowEdgeFade2")]
public float ShadowEdgeFade2 { get; set;}

[REDProp("shadowEdgeFade3")]
public float ShadowEdgeFade3 { get; set;}

[REDProp("shadowEdgeFade4")]
public float ShadowEdgeFade4 { get; set;}

[REDProp("shadowBiasOffsetSlopeMul")]
public float ShadowBiasOffsetSlopeMul { get; set;}

[REDProp("shadowBiasOffsetConst")]
public float ShadowBiasOffsetConst { get; set;}

[REDProp("shadowBiasOffsetConstCascade1")]
public float ShadowBiasOffsetConstCascade1 { get; set;}

[REDProp("shadowBiasOffsetConstCascade2")]
public float ShadowBiasOffsetConstCascade2 { get; set;}

[REDProp("shadowBiasOffsetConstCascade3")]
public float ShadowBiasOffsetConstCascade3 { get; set;}

[REDProp("shadowBiasOffsetConstCascade4")]
public float ShadowBiasOffsetConstCascade4 { get; set;}

[REDProp("shadowBiasCascadeMultiplier")]
public float ShadowBiasCascadeMultiplier { get; set;}

[REDProp("speedTreeShadowFilterSize1")]
public float SpeedTreeShadowFilterSize1 { get; set;}

[REDProp("speedTreeShadowFilterSize2")]
public float SpeedTreeShadowFilterSize2 { get; set;}

[REDProp("speedTreeShadowFilterSize3")]
public float SpeedTreeShadowFilterSize3 { get; set;}

[REDProp("speedTreeShadowFilterSize4")]
public float SpeedTreeShadowFilterSize4 { get; set;}

[REDProp("speedTreeShadowGradient")]
public float SpeedTreeShadowGradient { get; set;}

[REDProp("hiResShadowBiasOffsetSlopeMul")]
public float HiResShadowBiasOffsetSlopeMul { get; set;}

[REDProp("hiResShadowBiasOffsetConst")]
public float HiResShadowBiasOffsetConst { get; set;}

[REDProp("hiResShadowTexelRadius")]
public float HiResShadowTexelRadius { get; set;}

[REDProp("useTerrainShadows")]
public bool UseTerrainShadows { get; set;}

[REDProp("terrainShadowsDistance")]
public float TerrainShadowsDistance { get; set;}

[REDProp("terrainShadowsFadeRange")]
public float TerrainShadowsFadeRange { get; set;}

[REDProp("terrainShadowsBaseSmoothing")]
public float TerrainShadowsBaseSmoothing { get; set;}

[REDProp("terrainShadowsTerrainDistanceSoftness")]
public float TerrainShadowsTerrainDistanceSoftness { get; set;}

[REDProp("terrainShadowsMeshDistanceSoftness")]
public float TerrainShadowsMeshDistanceSoftness { get; set;}

[REDProp("terrainMeshShadowDistance")]
public float TerrainMeshShadowDistance { get; set;}

[REDProp("terrainMeshShadowFadeRange")]
public float TerrainMeshShadowFadeRange { get; set;}

#endregion
}
}