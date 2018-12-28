using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SGlobalSpeedTreeParameters 
{
#region RED Properties

[REDProp("alphaScalar3d")]
public float AlphaScalar3d { get; set;}

[REDProp("alphaScalarGrassNear")]
public float AlphaScalarGrassNear { get; set;}

[REDProp("alphaScalarGrass")]
public float AlphaScalarGrass { get; set;}

[REDProp("alphaScalarGrassDistNear")]
public float AlphaScalarGrassDistNear { get; set;}

[REDProp("alphaScalarGrassDistFar")]
public float AlphaScalarGrassDistFar { get; set;}

[REDProp("alphaScalarBillboards")]
public float AlphaScalarBillboards { get; set;}

[REDProp("billboardsGrainBias")]
public float BillboardsGrainBias { get; set;}

[REDProp("billboardsGrainAlbedoScale")]
public float BillboardsGrainAlbedoScale { get; set;}

[REDProp("billboardsGrainNormalScale")]
public float BillboardsGrainNormalScale { get; set;}

[REDProp("billboardsGrainClipScale")]
public float BillboardsGrainClipScale { get; set;}

[REDProp("billboardsGrainClipBias")]
public float BillboardsGrainClipBias { get; set;}

[REDProp("billboardsGrainClipDamping")]
public float BillboardsGrainClipDamping { get; set;}

[REDProp("grassNormalsVariation")]
public float GrassNormalsVariation { get; set;}

#endregion
}
}