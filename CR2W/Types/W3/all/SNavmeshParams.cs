using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SNavmeshParams 
{
#region RED Properties

[REDProp("useGenerationRootPoints")]
public bool UseGenerationRootPoints { get; set;}

[REDProp("useTerrainInGeneration")]
public bool UseTerrainInGeneration { get; set;}

[REDProp("useStaticMeshesInGeneration")]
public bool UseStaticMeshesInGeneration { get; set;}

[REDProp("collectFoliage")]
public bool CollectFoliage { get; set;}

[REDProp("previewOriginalGeometry")]
public bool PreviewOriginalGeometry { get; set;}

[REDProp("useCollisionMeshes")]
public bool UseCollisionMeshes { get; set;}

[REDProp("monotonePartitioning")]
public bool MonotonePartitioning { get; set;}

[REDProp("detectTerrainConnection")]
public bool DetectTerrainConnection { get; set;}

[REDProp("stepOnNonWalkableMeshes")]
public bool StepOnNonWalkableMeshes { get; set;}

[REDProp("cutMeshesWithBoundings")]
public bool CutMeshesWithBoundings { get; set;}

[REDProp("smoothWalkableAreas")]
public bool SmoothWalkableAreas { get; set;}

[REDProp("extensionLength")]
public float ExtensionLength { get; set;}

[REDProp("cellWidth")]
public float CellWidth { get; set;}

[REDProp("cellHeight")]
public float CellHeight { get; set;}

[REDProp("walkableSlopeAngle")]
public float WalkableSlopeAngle { get; set;}

[REDProp("agentHeight")]
public float AgentHeight { get; set;}

[REDProp("agentClimb")]
public float AgentClimb { get; set;}

[REDProp("margin")]
public float Margin { get; set;}

[REDProp("maxEdgeLen")]
public float MaxEdgeLen { get; set;}

[REDProp("maxEdgeError")]
public float MaxEdgeError { get; set;}

[REDProp("regionMinSize")]
public float RegionMinSize { get; set;}

[REDProp("regionMergeSize")]
public float RegionMergeSize { get; set;}

[REDProp("vertsPerPoly")]
public uint VertsPerPoly { get; set;}

[REDProp("detailSampleDist")]
public float DetailSampleDist { get; set;}

[REDProp("detailSampleMaxError")]
public float DetailSampleMaxError { get; set;}

[REDProp("extraStreamingRange")]
public float ExtraStreamingRange { get; set;}

#endregion
}
}