using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSetBehVarOnAnimEventDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("behVarName")]
public CName BehVarName { get; set;}

[REDProp("behVarValue")]
public float BehVarValue { get; set;}

[REDProp("onDurationEvent")]
public bool OnDurationEvent { get; set;}

[REDProp("behValueOnDurationEventStart")]
public float BehValueOnDurationEventStart { get; set;}

[REDProp("behValueOnDurationEventEnd")]
public float BehValueOnDurationEventEnd { get; set;}

#endregion
}
}