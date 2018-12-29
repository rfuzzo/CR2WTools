using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondCheckFactDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("fact")]
public string Fact { get; set;}

[REDProp("value")]
public Int32 Value { get; set;}

[REDProp("operator")]
public EOperator Operator { get; set;}

#endregion
}
}