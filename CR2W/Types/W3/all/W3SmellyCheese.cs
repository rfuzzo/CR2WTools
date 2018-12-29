using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SmellyCheese : W3AirDrainEntity
{
#region RED Properties

[REDProp("deactivatedByAard")]
public bool DeactivatedByAard { get; set;}

[REDProp("smellEffectName")]
public CName SmellEffectName { get; set;}

[REDProp("aardedEffectName")]
public CName AardedEffectName { get; set;}

[REDProp("reactivateTimer")]
public float ReactivateTimer { get; set;}

[REDProp("deactivated")]
public bool Deactivated { get; set;}

#endregion
}
}