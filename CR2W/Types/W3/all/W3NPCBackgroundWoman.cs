using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3NPCBackgroundWoman : CGameplayEntity
{
#region RED Properties

[REDProp("work")]
public EBackgroundNPCWomanWork Work { get; set;}

#endregion
}
}