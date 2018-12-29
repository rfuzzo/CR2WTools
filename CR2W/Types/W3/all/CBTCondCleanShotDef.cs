using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondCleanShotDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("doStaticTraceOnNavTestFailure")]
public bool DoStaticTraceOnNavTestFailure { get; set;}

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

#endregion
}
}