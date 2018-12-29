using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SProcessedDamage 
{
#region RED Properties

[REDProp("vitalityDamage")]
public float VitalityDamage { get; set;}

[REDProp("essenceDamage")]
public float EssenceDamage { get; set;}

[REDProp("moraleDamage")]
public float MoraleDamage { get; set;}

[REDProp("staminaDamage")]
public float StaminaDamage { get; set;}

#endregion
}
}