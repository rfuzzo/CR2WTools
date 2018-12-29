using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMeteoriteStormEntity : CGameplayEntity
{
#region RED Properties

[REDProp("resourceName")]
public CName ResourceName { get; set;}

[REDProp("timeBetweenSpawn")]
public float TimeBetweenSpawn { get; set;}

[REDProp("minDistFromTarget")]
public float MinDistFromTarget { get; set;}

[REDProp("maxDistFromTarget")]
public float MaxDistFromTarget { get; set;}

[REDProp("minDistFromEachOther")]
public float MinDistFromEachOther { get; set;}

[REDProp("victim")]
public Handle<CActor> Victim { get; set;}

[REDProp("entityTemplate")]
public Handle<CEntityTemplate> EntityTemplate { get; set;}

#endregion
}
}