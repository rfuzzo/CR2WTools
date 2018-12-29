using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskReactionToCustomHit : CBTTaskPlayAnimationEventDecorator
{
#region RED Properties

[REDProp("raiseEventName")]
public CName RaiseEventName { get; set;}

[REDProp("waitTimeout")]
public float WaitTimeout { get; set;}

[REDProp("activationTimeout")]
public float ActivationTimeout { get; set;}

[REDProp("timeStamp")]
public float TimeStamp { get; set;}

[REDProp("receivedEvent")]
public bool ReceivedEvent { get; set;}

[REDProp("isInCorrectBehGraphNode")]
public bool IsInCorrectBehGraphNode { get; set;}

[REDProp("activationScriptEvent")]
public CName ActivationScriptEvent { get; set;}

[REDProp("deactivateScriptEvent")]
public CName DeactivateScriptEvent { get; set;}

#endregion
}
}