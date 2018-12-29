using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationClimbOracle : CObject
{
#region RED Properties

[REDProp("m_ExplorationO")]
public Handle<CExplorationStateManager> M_ExplorationO { get; set;}

[REDProp("probeTop")]
public Handle<CClimbProbe> ProbeTop { get; set;}

[REDProp("probeBottom")]
public Handle<CClimbProbe> ProbeBottom { get; set;}

[REDProp("distForwardToCheck")]
public float DistForwardToCheck { get; set;}

[REDProp("characterRadius")]
public float CharacterRadius { get; set;}

[REDProp("characterHeight")]
public float CharacterHeight { get; set;}

[REDProp("radiusToCheck")]
public float RadiusToCheck { get; set;}

[REDProp("bottomCheckAllowed")]
public bool BottomCheckAllowed { get; set;}

[REDProp("topIsPriority")]
public bool TopIsPriority { get; set;}

[REDProp("probeBeingUsed")]
public EClimbProbeUsed ProbeBeingUsed { get; set;}

[REDProp("debugLogFails")]
public bool DebugLogFails { get; set;}

[REDProp("vectorUp")]
public Vector VectorUp { get; set;}

#endregion
}
}