using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSpawnObject : IBehTreeTask
{
#region RED Properties

[REDProp("useThisTask")]
public bool UseThisTask { get; set;}

[REDProp("objectTemplate")]
public Handle<CEntityTemplate> ObjectTemplate { get; set;}

[REDProp("useAnimEvent")]
public bool UseAnimEvent { get; set;}

[REDProp("spawnAnimEventName")]
public CName SpawnAnimEventName { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("spawnNodeTag")]
public CName SpawnNodeTag { get; set;}

[REDProp("spawnAtBonePosition")]
public bool SpawnAtBonePosition { get; set;}

[REDProp("boneName")]
public CName BoneName { get; set;}

[REDProp("spawnOnGround")]
public bool SpawnOnGround { get; set;}

[REDProp("groundZCheck")]
public float GroundZCheck { get; set;}

[REDProp("spawnPositionOffset")]
public Vector SpawnPositionOffset { get; set;}

[REDProp("offsetInLocalSpace")]
public bool OffsetInLocalSpace { get; set;}

[REDProp("randomizeOffset")]
public bool RandomizeOffset { get; set;}

[REDProp("spawnNodes")]
public Array<Handle<CNode>> SpawnNodes { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

[REDProp("size")]
public Int32 Size { get; set;}

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

#endregion
}
}