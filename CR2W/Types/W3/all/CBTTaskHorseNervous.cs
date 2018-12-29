using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHorseNervous : IBehTreeTask
{
#region RED Properties

[REDProp("timeTillNextNervous")]
public float TimeTillNextNervous { get; set;}

#endregion
}
}