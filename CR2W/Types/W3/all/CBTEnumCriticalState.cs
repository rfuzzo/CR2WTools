using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTEnumCriticalState : IBehTreeValueEnum
{
#region RED Properties

[REDProp("value")]
public ECriticalStateType Value { get; set;}

#endregion
}
}