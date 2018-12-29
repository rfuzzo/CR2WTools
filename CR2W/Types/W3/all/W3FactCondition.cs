using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3FactCondition : ISpawnScriptCondition
{
#region RED Properties

[REDProp("fact")]
public string Fact { get; set;}

[REDProp("factValue")]
public Int32 FactValue { get; set;}

[REDProp("operator")]
public EOperator Operator { get; set;}

[REDProp("queryFactVal")]
public Int32 QueryFactVal { get; set;}

#endregion
}
}