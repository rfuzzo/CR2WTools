using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFXExplosionImplosionPhysicalForce : IFXPhysicalForce
{
#region RED Properties

[REDProp("fieldType")]
public EFieldType FieldType { get; set;}

[REDProp("simulateLocalyInEntity")]
public bool SimulateLocalyInEntity { get; set;}

[REDProp("forceScale")]
public float ForceScale { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("applyFractureDamage")]
public float ApplyFractureDamage { get; set;}

#endregion
}
}