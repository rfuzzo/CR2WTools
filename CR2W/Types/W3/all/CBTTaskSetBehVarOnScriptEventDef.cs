using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSetBehVarOnScriptEventDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("activationEventName")]
public CName ActivationEventName { get; set;}

[REDProp("behVarName")]
public CName BehVarName { get; set;}

[REDProp("behVarValue")]
public float BehVarValue { get; set;}

[REDProp("delay")]
public float Delay { get; set;}

[REDProp("previousValueOnDurationEnd")]
public bool PreviousValueOnDurationEnd { get; set;}

#endregion
}
}