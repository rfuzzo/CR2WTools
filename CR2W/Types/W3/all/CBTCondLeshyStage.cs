using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondLeshyStage : IBehTreeTask
{
#region RED Properties

[REDProp("activeInStage")]
public ENPCFightStage ActiveInStage { get; set;}

[REDProp("equalHigherThanStage")]
public bool EqualHigherThanStage { get; set;}

#endregion
}
}