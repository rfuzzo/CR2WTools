using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondSwarmShieldAvailableDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("checkIsShieldInPlace")]
public bool CheckIsShieldInPlace { get; set;}

#endregion
}
}