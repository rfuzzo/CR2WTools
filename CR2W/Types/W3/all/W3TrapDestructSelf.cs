using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TrapDestructSelf : W3Trap
{
#region RED Properties

[REDProp("playEffectOnDestruct")]
public CName PlayEffectOnDestruct { get; set;}

[REDProp("onlyDestructOnAreaEnter")]
public bool OnlyDestructOnAreaEnter { get; set;}

[REDProp("denyAreaAfterDestruction")]
public bool DenyAreaAfterDestruction { get; set;}

[REDProp("excludedActorsTags")]
public Array<CName> ExcludedActorsTags { get; set;}

[REDProp("excludesblockDestruction")]
public bool ExcludesblockDestruction { get; set;}

[REDProp("m_actorsInTrigger")]
public Array<Handle<CActor>> M_actorsInTrigger { get; set;}

[REDProp("m_isDestroyed")]
public bool M_isDestroyed { get; set;}

#endregion
}
}