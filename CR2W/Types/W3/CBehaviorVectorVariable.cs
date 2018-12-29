using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorVectorVariable : CBaseBehaviorVariable
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("varIndex")]
public uint VarIndex { get; set;}

[REDProp("value")]
public Vector Value { get; set;}

[REDProp("defaultValue")]
public Vector DefaultValue { get; set;}

[REDProp("minValue")]
public Vector MinValue { get; set;}

[REDProp("maxValue")]
public Vector MaxValue { get; set;}

[REDProp("space")]
public EVariableSpace Space { get; set;}

[REDProp("type")]
public EVectorVariableType Type { get; set;}

[REDProp("shouldBeSyncedBetweenGraphs")]
public bool ShouldBeSyncedBetweenGraphs { get; set;}

#endregion
}
}