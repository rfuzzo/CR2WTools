using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SAbilityAttributeValue 
{
#region RED Properties

[REDProp("valueAdditive")]
public float ValueAdditive { get; set;}

[REDProp("valueMultiplicative")]
public float ValueMultiplicative { get; set;}

[REDProp("valueBase")]
public float ValueBase { get; set;}

#endregion
}
}