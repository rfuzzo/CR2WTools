using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFairytaleWitchTrigger : CGameplayEntity
{
#region RED Properties

[REDProp("areaNumber")]
public Int32 AreaNumber { get; set;}

#endregion
}
}