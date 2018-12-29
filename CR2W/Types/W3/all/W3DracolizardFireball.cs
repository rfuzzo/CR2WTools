using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3DracolizardFireball : W3FireballProjectile
{
#region RED Properties

[REDProp("range")]
public float Range { get; set;}

[REDProp("burningDur")]
public float BurningDur { get; set;}

[REDProp("destroyAfter")]
public float DestroyAfter { get; set;}

[REDProp("surfaceFX")]
public SFXSurfacePostParams SurfaceFX { get; set;}

#endregion
}
}