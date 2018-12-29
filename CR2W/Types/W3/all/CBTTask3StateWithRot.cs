using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTask3StateWithRot : CBTTask3StateAttack
{
#region RED Properties

[REDProp("endLeft")]
public EAttackType EndLeft { get; set;}

[REDProp("endRight")]
public EAttackType EndRight { get; set;}

#endregion
}
}