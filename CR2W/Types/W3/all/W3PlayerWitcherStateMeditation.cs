using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PlayerWitcherStateMeditation : W3PlayerWitcherStateMeditationBase
{
#region RED Properties

[REDProp("meditationPointHeading")]
public float MeditationPointHeading { get; set;}

[REDProp("meditationHeadingSet")]
public bool MeditationHeadingSet { get; set;}

[REDProp("stopRequested")]
public bool StopRequested { get; set;}

[REDProp("isSitting")]
public bool IsSitting { get; set;}

[REDProp("closeUIOnStop")]
public bool CloseUIOnStop { get; set;}

[REDProp("cameraIsLeavingState")]
public bool CameraIsLeavingState { get; set;}

[REDProp("isEntryFunctionLocked")]
public bool IsEntryFunctionLocked { get; set;}

[REDProp("scheduledGoToWaiting")]
public bool ScheduledGoToWaiting { get; set;}

[REDProp("changedContext")]
public bool ChangedContext { get; set;}

#endregion
}
}