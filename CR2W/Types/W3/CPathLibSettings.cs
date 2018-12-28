using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CPathLibSettings 
{
#region RED Properties

[REDProp("agentCategoriesCount")]
public uint AgentCategoriesCount { get; set;}

[REDProp("agentCategoryRadius1")]
public float AgentCategoryRadius1 { get; set;}

[REDProp("agentCategoryRadius2")]
public float AgentCategoryRadius2 { get; set;}

[REDProp("agentCategoryRadius3")]
public float AgentCategoryRadius3 { get; set;}

[REDProp("agentCategoryRadius4")]
public float AgentCategoryRadius4 { get; set;}

[REDProp("roadsNavcostMultiplier")]
public float RoadsNavcostMultiplier { get; set;}

[REDProp("maxTerrainSlope")]
public float MaxTerrainSlope { get; set;}

[REDProp("seaLevel")]
public float SeaLevel { get; set;}

[REDProp("desiredStreamingRange")]
public float DesiredStreamingRange { get; set;}

[REDProp("terrainWalkableRegionMinSize")]
public float TerrainWalkableRegionMinSize { get; set;}

[REDProp("terrainUnwalkableRegionMinSize")]
public float TerrainUnwalkableRegionMinSize { get; set;}

[REDProp("terrainNavmeshSurroundedRegionMinSize")]
public float TerrainNavmeshSurroundedRegionMinSize { get; set;}

[REDProp("terrainHeightApproximationRange")]
public float TerrainHeightApproximationRange { get; set;}

#endregion
}
}