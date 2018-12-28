using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
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