using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SnowballProjectile : W3AdvancedProjectile
{
#region RED Properties

[REDProp("damageTypeName")]
public CName DamageTypeName { get; set;}

[REDProp("initFxName")]
public CName InitFxName { get; set;}

[REDProp("onCollisionFxName")]
public CName OnCollisionFxName { get; set;}

[REDProp("specialFxOnVictimName")]
public CName SpecialFxOnVictimName { get; set;}

[REDProp("applyDebuffIfNoDmgWasDealt")]
public bool ApplyDebuffIfNoDmgWasDealt { get; set;}

#endregion
}
}