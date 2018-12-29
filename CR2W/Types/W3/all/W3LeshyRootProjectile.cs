using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3LeshyRootProjectile : CProjectileTrajectory
{
#region RED Properties

[REDProp("fxEntityTemplate")]
public Handle<CEntityTemplate> FxEntityTemplate { get; set;}

[REDProp("fxEntity")]
public Handle<CEntity> FxEntity { get; set;}

[REDProp("action")]
public Handle<W3DamageAction> Action { get; set;}

[REDProp("owner")]
public Handle<CActor> Owner { get; set;}

[REDProp("projPos")]
public Vector ProjPos { get; set;}

[REDProp("projRot")]
public EulerAngles ProjRot { get; set;}

[REDProp("projExpired")]
public bool ProjExpired { get; set;}

[REDProp("collisions")]
public Int32 Collisions { get; set;}

#endregion
}
}