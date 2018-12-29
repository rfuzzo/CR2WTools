using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SFormationConstraintDefinition 
{
#region RED Properties

[REDProp("referenceRelativeIndex")]
public bool ReferenceRelativeIndex { get; set;}

[REDProp("referenceSlot")]
public int ReferenceSlot { get; set;}

[REDProp("type")]
public EFormationConstraintType Type { get; set;}

[REDProp("value")]
public Vector2 Value { get; set;}

[REDProp("strength")]
public float Strength { get; set;}

[REDProp("tolerance")]
public float Tolerance { get; set;}

#endregion
}
}