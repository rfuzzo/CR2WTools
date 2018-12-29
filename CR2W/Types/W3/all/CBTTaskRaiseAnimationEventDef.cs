using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskRaiseAnimationEventDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("forceEvent")]
public bool ForceEvent { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("raiseEventAfter")]
public float RaiseEventAfter { get; set;}

#endregion
}
}