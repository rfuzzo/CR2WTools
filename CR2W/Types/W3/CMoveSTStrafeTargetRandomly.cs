using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMoveSTStrafeTargetRandomly : IMoveSTBaseStrafeTarget
{
#region RED Properties

[REDProp("namedTarget")]
public CName NamedTarget { get; set;}

[REDProp("customPosition")]
public CName CustomPosition { get; set;}

[REDProp("importance")]
public float Importance { get; set;}

[REDProp("acceleration")]
public float Acceleration { get; set;}

[REDProp("moveSpeed")]
public float MoveSpeed { get; set;}

[REDProp("randomizationFrequency")]
public float RandomizationFrequency { get; set;}

[REDProp("outputRandomizationPower")]
public float OutputRandomizationPower { get; set;}

[REDProp("changeDirectionOnBlockDelay")]
public float ChangeDirectionOnBlockDelay { get; set;}

#endregion
}
}