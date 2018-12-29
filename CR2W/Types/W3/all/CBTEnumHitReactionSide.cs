using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTEnumHitReactionSide : IBehTreeValueEnum
{
#region RED Properties

[REDProp("value")]
public EHitReactionSide Value { get; set;}

#endregion
}
}