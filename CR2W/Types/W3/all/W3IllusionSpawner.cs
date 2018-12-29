using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3IllusionSpawner : CGameplayEntity
{
#region RED Properties

[REDProp("m_illusionTemplate")]
public Handle<CEntityTemplate> M_illusionTemplate { get; set;}

[REDProp("m_factOnDispelOverride")]
public string M_factOnDispelOverride { get; set;}

[REDProp("l_illusion")]
public Handle<CEntity> L_illusion { get; set;}

[REDProp("spawnedIllusion")]
public Handle<W3IllusionaryObstacle> SpawnedIllusion { get; set;}

[REDProp("m_discoveryOneliner")]
public EIllusionDiscoveredOneliner M_discoveryOneliner { get; set;}

[REDProp("m_factOnDiscoveryOverride")]
public string M_factOnDiscoveryOverride { get; set;}

[REDProp("discoveryOnelinerTag")]
public string DiscoveryOnelinerTag { get; set;}

[REDProp("spawnedObstacleTags")]
public Array<CName> SpawnedObstacleTags { get; set;}

[REDProp("m_wasDestroyed")]
public bool M_wasDestroyed { get; set;}

#endregion
}
}