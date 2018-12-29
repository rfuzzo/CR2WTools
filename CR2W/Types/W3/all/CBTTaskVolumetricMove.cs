using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskVolumetricMove : IBehTreeTask
{
#region RED Properties

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("npc")]
public Handle<CNewNPC> Npc { get; set;}

[REDProp("target")]
public Handle<CNode> Target { get; set;}

[REDProp("dest")]
public Vector Dest { get; set;}

[REDProp("npcPos")]
public Vector NpcPos { get; set;}

[REDProp("targetPos")]
public Vector TargetPos { get; set;}

[REDProp("targetToNpcVec")]
public Vector TargetToNpcVec { get; set;}

[REDProp("npcToTargetVec")]
public Vector NpcToTargetVec { get; set;}

[REDProp("path")]
public Array<Vector> Path { get; set;}

[REDProp("m_collisionGroupsNames")]
public Array<CName> M_collisionGroupsNames { get; set;}

[REDProp("m_resetSweep")]
public bool M_resetSweep { get; set;}

[REDProp("m_sweepId")]
public SScriptSweepId M_sweepId { get; set;}

[REDProp("m_traceManager")]
public Handle<CScriptBatchQueryAccessor> M_traceManager { get; set;}

[REDProp("m_lastSweepResult")]
public bool M_lastSweepResult { get; set;}

#endregion
}
}