using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SummonedFlies : CGameplayEntity
{
#region RED Properties

[REDProp("fleeDuration")]
public float FleeDuration { get; set;}

[REDProp("lookForTarget")]
public bool LookForTarget { get; set;}

[REDProp("detectionDistance")]
public float DetectionDistance { get; set;}

[REDProp("pursueDistance")]
public float PursueDistance { get; set;}

[REDProp("ignoreTag")]
public CName IgnoreTag { get; set;}

[REDProp("m_Target")]
public Handle<CNode> M_Target { get; set;}

[REDProp("m_StartPos")]
public Vector M_StartPos { get; set;}

[REDProp("m_SummonedCmp")]
public Handle<W3SummonedEntityComponent> M_SummonedCmp { get; set;}

[REDProp("m_SlideCmp")]
public Handle<W3SlideToTargetComponent> M_SlideCmp { get; set;}

#endregion
}
}