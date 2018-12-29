using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4FinisherDLC : CObject
{
#region RED Properties

[REDProp("finisherAnimName")]
public CName FinisherAnimName { get; set;}

[REDProp("woundName")]
public CName WoundName { get; set;}

[REDProp("finisherSide")]
public EFinisherSide FinisherSide { get; set;}

[REDProp("leftCameraAnimName")]
public CName LeftCameraAnimName { get; set;}

[REDProp("rightCameraAnimName")]
public CName RightCameraAnimName { get; set;}

[REDProp("frontCameraAnimName")]
public CName FrontCameraAnimName { get; set;}

[REDProp("backCameraAnimName")]
public CName BackCameraAnimName { get; set;}

#endregion
}
}