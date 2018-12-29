using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskAddRemoveAbility : IBehTreeTask
{
#region RED Properties

[REDProp("abilityName")]
public CName AbilityName { get; set;}

[REDProp("allowMultiple")]
public bool AllowMultiple { get; set;}

[REDProp("removeAbility")]
public bool RemoveAbility { get; set;}

[REDProp("delayUntilInCameraFrame")]
public bool DelayUntilInCameraFrame { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onAnimEventName")]
public CName OnAnimEventName { get; set;}

[REDProp("eventReceived")]
public bool EventReceived { get; set;}

#endregion
}
}