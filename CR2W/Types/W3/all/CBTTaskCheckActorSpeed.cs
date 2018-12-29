using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskCheckActorSpeed : IBehTreeTask
{
#region RED Properties

[REDProp("checkedActor")]
public EStatOwner CheckedActor { get; set;}

[REDProp("moveType")]
public EMoveType MoveType { get; set;}

[REDProp("operator")]
public EOperator Operator { get; set;}

[REDProp("customSpeed")]
public bool CustomSpeed { get; set;}

[REDProp("moveSpeed")]
public float MoveSpeed { get; set;}

[REDProp("currentSpeed")]
public float CurrentSpeed { get; set;}

#endregion
}
}