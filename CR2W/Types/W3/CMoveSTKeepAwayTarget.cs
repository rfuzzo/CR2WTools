using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTKeepAwayTarget : IMoveSteeringTask
{
#region RED Properties

[REDProp("headingImportance")]
public float HeadingImportance { get; set;}

[REDProp("speed")]
public float Speed { get; set;}

#endregion
}
}