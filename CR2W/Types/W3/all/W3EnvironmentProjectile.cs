using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3EnvironmentProjectile : W3AdvancedProjectile
{
#region RED Properties

[REDProp("initFxName")]
public CName InitFxName { get; set;}

[REDProp("stopFxOnDeactivate")]
public CName StopFxOnDeactivate { get; set;}

[REDProp("onCollisionFxName")]
public CName OnCollisionFxName { get; set;}

[REDProp("ignoreVictimsWithTag")]
public CName IgnoreVictimsWithTag { get; set;}

[REDProp("action")]
public Handle<W3DamageAction> Action { get; set;}

[REDProp("comp")]
public Handle<CMeshComponent> Comp { get; set;}

#endregion
}
}