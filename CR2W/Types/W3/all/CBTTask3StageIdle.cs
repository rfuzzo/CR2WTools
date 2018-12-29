using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTask3StageIdle : IBehTreeTask
{
#region RED Properties

[REDProp("minTime")]
public float MinTime { get; set;}

[REDProp("maxTime")]
public float MaxTime { get; set;}

[REDProp("loopTime")]
public float LoopTime { get; set;}

#endregion
}
}