using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CFurMeshResource : CMeshTypeResource
{
#region RED Properties

[REDProp("materials")]
public Array<Handle<IMaterial>> Materials { get; set;}

[REDProp("boundingBox")]
public Box BoundingBox { get; set;}

[REDProp("autoHideDistance")]
public float AutoHideDistance { get; set;}

[REDProp("isTwoSided")]
public bool IsTwoSided { get; set;}

[REDProp("positions")]
public Array<Vector> Positions { get; set;}

[REDProp("uvs")]
public Array<Vector2> Uvs { get; set;}

[REDProp("endIndices")]
public Array<UInt32> EndIndices { get; set;}

[REDProp("faceIndices")]
public Array<UInt32> FaceIndices { get; set;}

[REDProp("boneIndices")]
public Array<Vector> BoneIndices { get; set;}

[REDProp("boneWeights")]
public Array<Vector> BoneWeights { get; set;}

[REDProp("boneCount")]
public uint BoneCount { get; set;}

[REDProp("boneNames")]
public Array<CName> BoneNames { get; set;}

[REDProp("boneRigMatrices")]
public Array<Matrix> BoneRigMatrices { get; set;}

[REDProp("boneParents")]
public Array<Int32> BoneParents { get; set;}

[REDProp("bindPoses")]
public Array<Matrix> BindPoses { get; set;}

[REDProp("boneSphereLocalPosArray")]
public Array<Vector> BoneSphereLocalPosArray { get; set;}

[REDProp("boneSphereIndexArray")]
public Array<uint> BoneSphereIndexArray { get; set;}

[REDProp("boneSphereRadiusArray")]
public Array<float> BoneSphereRadiusArray { get; set;}

[REDProp("boneCapsuleIndices")]
public Array<uint> BoneCapsuleIndices { get; set;}

[REDProp("boneVertexEpsilons")]
public Array<float> BoneVertexEpsilons { get; set;}

[REDProp("pinConstraintsLocalPosArray")]
public Array<Vector> PinConstraintsLocalPosArray { get; set;}

[REDProp("pinConstraintsIndexArray")]
public Array<uint> PinConstraintsIndexArray { get; set;}

[REDProp("pinConstraintsRadiusArray")]
public Array<float> PinConstraintsRadiusArray { get; set;}

[REDProp("splineMultiplier")]
public uint SplineMultiplier { get; set;}

[REDProp("visualizers")]
public SFurVisualizers Visualizers { get; set;}

[REDProp("physicalMaterials")]
public SFurPhysicalMaterials PhysicalMaterials { get; set;}

[REDProp("graphicalMaterials")]
public SFurGraphicalMaterials GraphicalMaterials { get; set;}

[REDProp("levelOfDetail")]
public SFurLevelOfDetail LevelOfDetail { get; set;}

[REDProp("materialWeight")]
public float MaterialWeight { get; set;}

[REDProp("materialSets")]
public SFurMaterialSet MaterialSets { get; set;}

[REDProp("importUnitsScale")]
public float ImportUnitsScale { get; set;}

#endregion
}
}