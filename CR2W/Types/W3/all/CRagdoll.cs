using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CRagdoll : CResource
{
#region RED Properties

[REDProp("windScaler")]
public float WindScaler { get; set;}

[REDProp("densityScaler")]
public float DensityScaler { get; set;}

[REDProp("autoStopDelay")]
public float AutoStopDelay { get; set;}

[REDProp("autoStopTime")]
public float AutoStopTime { get; set;}

[REDProp("autoStopSpeed")]
public float AutoStopSpeed { get; set;}

[REDProp("resetDampingAfterStop")]
public bool ResetDampingAfterStop { get; set;}

[REDProp("forceWakeUpOnAttach")]
public bool ForceWakeUpOnAttach { get; set;}

[REDProp("customDynamicGroup")]
public CPhysicalCollision CustomDynamicGroup { get; set;}

[REDProp("disableConstrainsTwistAxis")]
public bool DisableConstrainsTwistAxis { get; set;}

[REDProp("disableConstrainsSwing1Axis")]
public bool DisableConstrainsSwing1Axis { get; set;}

[REDProp("disableConstrainsSwing2Axis")]
public bool DisableConstrainsSwing2Axis { get; set;}

[REDProp("jointBounce")]
public float JointBounce { get; set;}

[REDProp("modifyTwistLower")]
public float ModifyTwistLower { get; set;}

[REDProp("modifyTwistUpper")]
public float ModifyTwistUpper { get; set;}

[REDProp("modifySwingY")]
public float ModifySwingY { get; set;}

[REDProp("modifySwingZ")]
public float ModifySwingZ { get; set;}

[REDProp("projectionIterations")]
public int ProjectionIterations { get; set;}

#endregion
}
}