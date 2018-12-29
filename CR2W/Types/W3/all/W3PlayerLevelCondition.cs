using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PlayerLevelCondition : ISpawnScriptCondition
{
#region RED Properties

[REDProp("level")]
public Int32 Level { get; set;}

[REDProp("operator")]
public EOperator Operator { get; set;}

[REDProp("queryVal")]
public Int32 QueryVal { get; set;}

#endregion
}
}