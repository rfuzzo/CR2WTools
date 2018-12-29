using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TrapTrigger : W3GameplayTrigger
{
#region RED Properties

[REDProp("m_TrapsToActivateTag")]
public CName M_TrapsToActivateTag { get; set;}

[REDProp("m_MaxActivation")]
public Int32 M_MaxActivation { get; set;}

[REDProp("m_DeactivateOnExit")]
public bool M_DeactivateOnExit { get; set;}

[REDProp("m_Enabled")]
public bool M_Enabled { get; set;}

[REDProp("m_playerOnly")]
public bool M_playerOnly { get; set;}

[REDProp("m_excludedEntitiesTags")]
public Array<CName> M_excludedEntitiesTags { get; set;}

[REDProp("m_trapsToActivateByTag")]
public Array<Handle<CEntity>> M_trapsToActivateByTag { get; set;}

[REDProp("m_Activations")]
public Int32 M_Activations { get; set;}

[REDProp("m_EntitiesInside")]
public Int32 M_EntitiesInside { get; set;}

#endregion
}
}