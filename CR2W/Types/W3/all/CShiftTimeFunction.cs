using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CShiftTimeFunction : IQuestTimeFunction
{
#region RED Properties

[REDProp("timeShift")]
public GameTime TimeShift { get; set;}

[REDProp("callEvents")]
public bool CallEvents { get; set;}

#endregion
}
}