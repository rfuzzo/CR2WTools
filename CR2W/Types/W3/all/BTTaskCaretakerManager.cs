using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskCaretakerManager : IBehTreeTask
{
#region RED Properties

[REDProp("drainTemplate")]
public Handle<CEntityTemplate> DrainTemplate { get; set;}

[REDProp("recoverPercPerHit")]
public float RecoverPercPerHit { get; set;}

[REDProp("shadesModifier")]
public float ShadesModifier { get; set;}

[REDProp("m_Npc")]
public Handle<CNewNPC> M_Npc { get; set;}

[REDProp("m_HealthObjective")]
public float M_HealthObjective { get; set;}

[REDProp("m_DrainEffectEntity")]
public Handle<CEntity> M_DrainEffectEntity { get; set;}

[REDProp("m_SummonerComponent")]
public Handle<W3SummonerComponent> M_SummonerComponent { get; set;}

[REDProp("m_RefreshTargetDelay")]
public float M_RefreshTargetDelay { get; set;}

#endregion
}
}