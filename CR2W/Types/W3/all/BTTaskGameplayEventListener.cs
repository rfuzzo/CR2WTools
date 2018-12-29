using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskGameplayEventListener : IBehTreeTask
{
#region RED Properties

[REDProp("validFor")]
public float ValidFor { get; set;}

[REDProp("activeFor")]
public float ActiveFor { get; set;}

[REDProp("activate")]
public bool Activate { get; set;}

[REDProp("eventTime")]
public float EventTime { get; set;}

[REDProp("eventNam")]
public CName EventNam { get; set;}

[REDProp("activationTime")]
public float ActivationTime { get; set;}

[REDProp("clearOnEvent")]
public CName ClearOnEvent { get; set;}

#endregion
}
}