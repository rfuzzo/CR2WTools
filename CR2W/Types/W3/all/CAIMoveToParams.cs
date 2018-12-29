using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIMoveToParams : IAIActionParameters
{
#region RED Properties

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("moveSpeed")]
public float MoveSpeed { get; set;}

[REDProp("moveType")]
public EMoveType MoveType { get; set;}

[REDProp("targetTag")]
public CName TargetTag { get; set;}

[REDProp("rotateAfterwards")]
public bool RotateAfterwards { get; set;}

[REDProp("tolerance")]
public float Tolerance { get; set;}

#endregion
}
}