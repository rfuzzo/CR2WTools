using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SFurVisualizers 
{
#region RED Properties

[REDProp("drawRenderHairs")]
public bool DrawRenderHairs { get; set;}

[REDProp("visualizeBones")]
public bool VisualizeBones { get; set;}

[REDProp("visualizeCapsules")]
public bool VisualizeCapsules { get; set;}

[REDProp("visualizeGuideHairs")]
public bool VisualizeGuideHairs { get; set;}

[REDProp("visualizeControlVertices")]
public bool VisualizeControlVertices { get; set;}

[REDProp("visualizeBoundingBox")]
public bool VisualizeBoundingBox { get; set;}

[REDProp("colorizeMode")]
public EHairColorizeMode ColorizeMode { get; set;}

[REDProp("visualizeCullSphere")]
public bool VisualizeCullSphere { get; set;}

[REDProp("visualizeDiffuseBone")]
public bool VisualizeDiffuseBone { get; set;}

[REDProp("visualizeFrames")]
public bool VisualizeFrames { get; set;}

[REDProp("visualizeGrowthMesh")]
public bool VisualizeGrowthMesh { get; set;}

[REDProp("visualizeHairInteractions")]
public bool VisualizeHairInteractions { get; set;}

[REDProp("visualizeHairSkips")]
public uint VisualizeHairSkips { get; set;}

[REDProp("visualizeLocalPos")]
public bool VisualizeLocalPos { get; set;}

[REDProp("visualizePinConstraints")]
public bool VisualizePinConstraints { get; set;}

[REDProp("visualizeShadingNormals")]
public bool VisualizeShadingNormals { get; set;}

[REDProp("visualizeSkinnedGuideHairs")]
public bool VisualizeSkinnedGuideHairs { get; set;}

[REDProp("visualizeStiffnessBone")]
public bool VisualizeStiffnessBone { get; set;}

#endregion
}
}