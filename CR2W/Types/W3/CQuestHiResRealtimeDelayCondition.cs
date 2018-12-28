using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestHiResRealtimeDelayCondition : IQuestCondition
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("hours")]
public uint Hours { get; set;}

[REDProp("minutes")]
public uint Minutes { get; set;}

[REDProp("seconds")]
public uint Seconds { get; set;}

[REDProp("miliseconds")]
public uint Miliseconds { get; set;}

#endregion
}
}