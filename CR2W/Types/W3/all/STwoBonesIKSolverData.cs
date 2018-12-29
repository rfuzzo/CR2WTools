using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class STwoBonesIKSolverData 
{
#region RED Properties

[REDProp("upperBone")]
public STwoBonesIKSolverBoneData UpperBone { get; set;}

[REDProp("jointBone")]
public STwoBonesIKSolverBoneData JointBone { get; set;}

[REDProp("subLowerBone")]
public STwoBonesIKSolverBoneData SubLowerBone { get; set;}

[REDProp("lowerBone")]
public STwoBonesIKSolverBoneData LowerBone { get; set;}

[REDProp("ikBone")]
public STwoBonesIKSolverBoneData IkBone { get; set;}

[REDProp("limitToLengthPercentage")]
public float LimitToLengthPercentage { get; set;}

[REDProp("reverseBend")]
public bool ReverseBend { get; set;}

[REDProp("allowToLock")]
public bool AllowToLock { get; set;}

[REDProp("autoSetupDirs")]
public bool AutoSetupDirs { get; set;}

[REDProp("jointSideWeightUpper")]
public float JointSideWeightUpper { get; set;}

[REDProp("jointSideWeightJoint")]
public float JointSideWeightJoint { get; set;}

[REDProp("jointSideWeightLower")]
public float JointSideWeightLower { get; set;}

#endregion
}
}