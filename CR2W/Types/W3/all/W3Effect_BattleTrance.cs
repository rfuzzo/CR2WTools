using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Effect_BattleTrance : CBaseGameplayEffect
{
#region RED Properties

[REDProp("currentFocusLevel")]
public Int32 CurrentFocusLevel { get; set;}

#endregion
}
}