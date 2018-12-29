using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIActionLoop : IAIActionTree
{
#region RED Properties

[REDProp("loopCount")]
public Int32 LoopCount { get; set;}

[REDProp("loopedAction")]
public Handle<IAIActionTree> LoopedAction { get; set;}

#endregion
}
}