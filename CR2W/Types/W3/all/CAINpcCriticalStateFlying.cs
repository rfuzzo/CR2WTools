using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAINpcCriticalStateFlying : CAICombatActionTree
{
#region RED Properties

[REDProp("params")]
public Handle<CAINpcCriticalStateParams> Params { get; set;}

#endregion
}
}