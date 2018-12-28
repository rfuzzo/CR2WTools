using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
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

/*[REDProp("Joint to-next dir in upper's BS")]
public Vector Joint to-next dir in upper's BS { get; set;}

[REDProp("Joint to-next dir in joint's BS")]
public Vector Joint to-next dir in joint's BS { get; set;}

[REDProp("Joint to-next dir in lower's BS")]
public Vector Joint to-next dir in lower's BS { get; set;}

[REDProp("Joint side dir in upper's BS")]
public Vector Joint side dir in upper's BS { get; set;}

[REDProp("Joint side dir in joint's BS")]
public Vector Joint side dir in joint's BS { get; set;}

[REDProp("Joint side dir in lower's BS")]
public Vector Joint side dir in lower's BS { get; set;}

[REDProp("Joint bend dir in upper's BS")]
public Vector Joint bend dir in upper's BS { get; set;}

[REDProp("Joint bend dir in joint's BS")]
public Vector Joint bend dir in joint's BS { get; set;}

[REDProp("Joint bend dir in lower's BS")]
public Vector Joint bend dir in lower's BS { get; set;}*/

#endregion
}
}