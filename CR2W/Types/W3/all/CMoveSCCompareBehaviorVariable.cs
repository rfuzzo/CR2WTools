using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMoveSCCompareBehaviorVariable : IMoveSteeringCondition
{
#region RED Properties

[REDProp("variableName")]
public CName VariableName { get; set;}

[REDProp("referenceVal")]
public float ReferenceVal { get; set;}

[REDProp("comparison")]
public ECompareFunc Comparison { get; set;}

#endregion
}
}