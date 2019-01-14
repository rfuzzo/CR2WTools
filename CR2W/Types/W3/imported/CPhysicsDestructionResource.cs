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
public class CPhysicsDestructionResource : CMesh
{
#region RED Properties

[REDProp("materials", 2,0)]
public Array<Handle<IMaterial>> Materials { get; set;}

[REDProp("boundingBox")]
public Box BoundingBox { get; set;}

[REDProp("autoHideDistance")]
public float AutoHideDistance { get; set;}

[REDProp("isTwoSided")]
public bool IsTwoSided { get; set;}

[REDProp("collisionMesh")]
public Handle<CCollisionMesh> CollisionMesh { get; set;}

[REDProp("useExtraStreams")]
public bool UseExtraStreams { get; set;}

[REDProp("generalizedMeshRadius")]
public float GeneralizedMeshRadius { get; set;}

[REDProp("mergeInGlobalShadowMesh")]
public bool MergeInGlobalShadowMesh { get; set;}

[REDProp("isOccluder")]
public bool IsOccluder { get; set;}

[REDProp("smallestHoleOverride")]
public float SmallestHoleOverride { get; set;}

[REDProp("chunks", 2,0)]
public Array<SMeshChunkPacked> Chunks { get; set;}

[REDProp("rawVertices")]
public DeferredDataBuffer RawVertices { get; set;}

[REDProp("rawIndices")]
public DeferredDataBuffer RawIndices { get; set;}

[REDProp("isStatic")]
public bool IsStatic { get; set;}

[REDProp("entityProxy")]
public bool EntityProxy { get; set;}

[REDProp("cookedData")]
public SMeshCookedData CookedData { get; set;}

[REDProp("soundInfo")]
public Ptr<SMeshSoundInfo> SoundInfo { get; set;}

[REDProp("internalVersion")]
public byte InternalVersion { get; set;}

[REDProp("chunksBuffer")]
public DeferredDataBuffer ChunksBuffer { get; set;}

[REDProp("boneIndicesMapping", 2,0)]
public Array<SBoneIndiceMapping> BoneIndicesMapping { get; set;}

[REDProp("finalIndices", 2,0,16)]
public Array<UInt16> FinalIndices { get; set;}

[REDProp("chunkNumber")]
public UInt32 ChunkNumber { get; set;}

#endregion
}
}