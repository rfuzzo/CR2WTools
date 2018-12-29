using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSelectTargetFromList : IBehTreeTask
{
#region RED Properties

[REDProp("targetList")]
public Array<CName> TargetList { get; set;}

[REDProp("currentTargetIndex")]
public Int32 CurrentTargetIndex { get; set;}

[REDProp("currentTarget")]
public Handle<CNode> CurrentTarget { get; set;}

[REDProp("targetToSelect")]
public Handle<CNode> TargetToSelect { get; set;}

#endregion
}
}