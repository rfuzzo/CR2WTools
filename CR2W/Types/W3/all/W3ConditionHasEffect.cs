using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ConditionHasEffect : W3Condition
{
#region RED Properties

[REDProp("effect")]
public EEffectType Effect { get; set;}

#endregion
}
}