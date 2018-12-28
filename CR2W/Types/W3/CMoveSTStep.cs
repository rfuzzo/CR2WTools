using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTStep : IMoveSteeringTask
{
#region RED Properties

[REDProp("stepDistanceVar")]
public CName StepDistanceVar { get; set;}

[REDProp("stepHeadingVar")]
public CName StepHeadingVar { get; set;}

[REDProp("stepEvent")]
public CName StepEvent { get; set;}

[REDProp("stepNotification")]
public CName StepNotification { get; set;}

#endregion
}
}