using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondLeshyStageDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("equalHigherThanStage")]
public bool EqualHigherThanStage { get; set;}

[REDProp("activeInStage")]
public ENPCFightStage ActiveInStage { get; set;}

#endregion
}
}