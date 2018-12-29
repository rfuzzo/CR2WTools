using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondHitCounter : IBehTreeTask
{
#region RED Properties

[REDProp("value")]
public float Value { get; set;}

[REDProp("operator")]
public EOperator Operator { get; set;}

[REDProp("total")]
public bool Total { get; set;}

#endregion
}
}