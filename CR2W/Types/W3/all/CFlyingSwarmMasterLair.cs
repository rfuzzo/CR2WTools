using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFlyingSwarmMasterLair : CFlyingCrittersLairEntityScript
{
#region RED Properties

[REDProp("m_spawnFromBirdMasterRequest")]
public Int32 M_spawnFromBirdMasterRequest { get; set;}

[REDProp("m_spawnFromShieldGroupRequest")]
public Int32 M_spawnFromShieldGroupRequest { get; set;}

[REDProp("m_despawnFromBirdMasterRequest")]
public Int32 M_despawnFromBirdMasterRequest { get; set;}

[REDProp("teleportGroupId")]
public CFlyingGroupId TeleportGroupId { get; set;}

[REDProp("shieldGroupId")]
public CFlyingGroupId ShieldGroupId { get; set;}

[REDProp("passedInput")]
public Handle<CFlyingSwarmScriptInput> PassedInput { get; set;}

[REDProp("m_init")]
public bool M_init { get; set;}

[REDProp("disperseShield")]
public bool DisperseShield { get; set;}

[REDProp("teleportGroupPosition")]
public Vector TeleportGroupPosition { get; set;}

[REDProp("shieldBirdCount")]
public Int32 ShieldBirdCount { get; set;}

[REDProp("teleportBirdCount")]
public Int32 TeleportBirdCount { get; set;}

[REDProp("spawnCount")]
public Int32 SpawnCount { get; set;}

[REDProp("checkBeginAttackArray")]
public Array<CFlyingGroupId> CheckBeginAttackArray { get; set;}

[REDProp("shieldBirdState")]
public CName ShieldBirdState { get; set;}

#endregion
}
}