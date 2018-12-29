using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondSynchronisedDelay : IBehTreeTask
{
#region RED Properties

[REDProp("syncEventName")]
public CName SyncEventName { get; set;}

[REDProp("delay")]
public float Delay { get; set;}

[REDProp("skipInvoker")]
public bool SkipInvoker { get; set;}

[REDProp("triggerEventOnActivate")]
public bool TriggerEventOnActivate { get; set;}

[REDProp("triggerEventOnDeactivate")]
public bool TriggerEventOnDeactivate { get; set;}

[REDProp("triggerEventOnSuccess")]
public bool TriggerEventOnSuccess { get; set;}

[REDProp("triggerEventOnFailed")]
public bool TriggerEventOnFailed { get; set;}

[REDProp("isAvailableUntilFirstEvent")]
public bool IsAvailableUntilFirstEvent { get; set;}

[REDProp("personalSync")]
public bool PersonalSync { get; set;}

[REDProp("m_eventReceivedTime")]
public float M_eventReceivedTime { get; set;}

#endregion
}
}