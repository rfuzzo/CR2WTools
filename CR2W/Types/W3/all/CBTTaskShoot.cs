using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskShoot : CBTTaskPlayAnimationEventDecorator
{
#region RED Properties

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("attackRange")]
public float AttackRange { get; set;}

[REDProp("setArrowOnFire")]
public bool SetArrowOnFire { get; set;}

[REDProp("dodgeable")]
public bool Dodgeable { get; set;}

[REDProp("arrow")]
public Handle<W3ArrowProjectile> Arrow { get; set;}

[REDProp("projShot")]
public bool ProjShot { get; set;}

#endregion
}
}