using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CPauseTimeFunction : IQuestTimeFunction
{
#region RED Properties

[REDProp("pause")]
public bool Pause { get; set;}

#endregion
}
}