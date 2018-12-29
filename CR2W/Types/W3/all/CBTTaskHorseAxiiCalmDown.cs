using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHorseAxiiCalmDown : IBehTreeTask
{
#region RED Properties

[REDProp("inProgress")]
public bool InProgress { get; set;}

[REDProp("horseMounted")]
public bool HorseMounted { get; set;}

#endregion
}
}