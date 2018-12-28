using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehaviorGraphComboLevelModifier : IBehaviorGraphComboModifier
{
#region RED Properties

[REDProp("level")]
public uint Level { get; set;}

#endregion
}
}