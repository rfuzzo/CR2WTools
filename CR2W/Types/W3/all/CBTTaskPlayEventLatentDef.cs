using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPlayEventLatentDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("nodeDeactivationName")]
public CName NodeDeactivationName { get; set;}

[REDProp("playEventName")]
public CName PlayEventName { get; set;}

[REDProp("eventIsForced")]
public bool EventIsForced { get; set;}

[REDProp("setVariable")]
public bool SetVariable { get; set;}

[REDProp("variableName")]
public CName VariableName { get; set;}

[REDProp("variableValue")]
public float VariableValue { get; set;}

#endregion
}
}