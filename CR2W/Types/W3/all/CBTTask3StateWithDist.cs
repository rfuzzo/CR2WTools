using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTask3StateWithDist : CBTTask3StateAttack
{
#region RED Properties

[REDProp("distance")]
public float Distance { get; set;}

[REDProp("endLess")]
public EAttackType EndLess { get; set;}

[REDProp("endMore")]
public EAttackType EndMore { get; set;}

#endregion
}
}