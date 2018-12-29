using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehaviorVariable : CBaseBehaviorVariable
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("varIndex")]
public uint VarIndex { get; set;}

[REDProp("value")]
public float Value { get; set;}

[REDProp("defaultValue")]
public float DefaultValue { get; set;}

[REDProp("minValue")]
public float MinValue { get; set;}

[REDProp("maxValue")]
public float MaxValue { get; set;}

[REDProp("isModifiableByEffect")]
public bool IsModifiableByEffect { get; set;}

[REDProp("shouldBeSyncedBetweenGraphs")]
public bool ShouldBeSyncedBetweenGraphs { get; set;}

#endregion
}
}