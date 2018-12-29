using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SBehaviorConstraintUprightSpineBonesData 
{
#region RED Properties

[REDProp("boneName")]
public CName BoneName { get; set;}

[REDProp("weight")]
public float Weight { get; set;}

[REDProp("boneCount")]
public int BoneCount { get; set;}

#endregion
}
}