using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSetBehVar : IBehTreeTask
{
#region RED Properties

[REDProp("behVarName")]
public CName BehVarName { get; set;}

[REDProp("behVarValue")]
public float BehVarValue { get; set;}

[REDProp("inAllBehGraphs")]
public bool InAllBehGraphs { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onSuccess")]
public bool OnSuccess { get; set;}

#endregion
}
}