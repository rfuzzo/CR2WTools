using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_BleedingTracking : W3DamageOverTimeEffect
{
#region RED Properties

[REDProp("bloodTemplate")]
public Handle<CEntityTemplate> BloodTemplate { get; set;}

[REDProp("bloodSpawnTimer")]
public float BloodSpawnTimer { get; set;}

[REDProp("BLOOD_SPAWN_DELAY_MIN")]
public Int32 BLOOD_SPAWN_DELAY_MIN { get; set;}

[REDProp("BLOOD_SPAWN_DELAY_MAX")]
public Int32 BLOOD_SPAWN_DELAY_MAX { get; set;}

#endregion
}
}