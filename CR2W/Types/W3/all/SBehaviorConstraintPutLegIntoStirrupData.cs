using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SBehaviorConstraintPutLegIntoStirrupData 
{
#region RED Properties

[REDProp("footStoreName")]
public CName FootStoreName { get; set;}

[REDProp("stirrupStoreName")]
public CName StirrupStoreName { get; set;}

[REDProp("stirrupFinalStoreName")]
public CName StirrupFinalStoreName { get; set;}

[REDProp("ik")]
public STwoBonesIKSolverData Ik { get; set;}

[REDProp("additionalSideDirForIKMS")]
public Vector AdditionalSideDirForIKMS { get; set;}

#endregion
}
}