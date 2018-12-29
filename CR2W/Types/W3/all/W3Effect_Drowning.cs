using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_Drowning : W3DamageOverTimeEffect
{
#region RED Properties

[REDProp("m_NoSaveLockInt")]
public Int32 M_NoSaveLockInt { get; set;}

[REDProp("isEffectOn")]
public bool IsEffectOn { get; set;}

[REDProp("mac")]
public Handle<CMovingPhysicalAgentComponent> Mac { get; set;}

[REDProp("submergeDepth")]
public float SubmergeDepth { get; set;}

#endregion
}
}