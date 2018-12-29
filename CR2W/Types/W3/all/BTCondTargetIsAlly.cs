using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondTargetIsAlly : IBehTreeTask
{
#region RED Properties

[REDProp("useNamedTarget")]
public CName UseNamedTarget { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("saveTargetOnGameplayEvents")]
public Array<CName> SaveTargetOnGameplayEvents { get; set;}

[REDProp("m_Target")]
public Handle<CActor> M_Target { get; set;}

#endregion
}
}