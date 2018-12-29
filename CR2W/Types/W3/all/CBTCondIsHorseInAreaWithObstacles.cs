using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondIsHorseInAreaWithObstacles : IBehTreeTask
{
#region RED Properties

[REDProp("testRadius")]
public float TestRadius { get; set;}

[REDProp("testFreq")]
public float TestFreq { get; set;}

[REDProp("lastTestTime")]
public float LastTestTime { get; set;}

[REDProp("lastResult")]
public bool LastResult { get; set;}

#endregion
}
}