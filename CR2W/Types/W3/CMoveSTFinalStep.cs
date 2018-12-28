using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMoveSTFinalStep : CMoveSTMove
{
#region RED Properties

[REDProp("headingImportance")]
public float HeadingImportance { get; set;}

[REDProp("speedImportance")]
public float SpeedImportance { get; set;}

[REDProp("ignoreGoalToleranceForFinalLocation")]
public bool IgnoreGoalToleranceForFinalLocation { get; set;}

[REDProp("finalStepPositionVar")]
public CName FinalStepPositionVar { get; set;}

[REDProp("finalStepDistanceVar")]
public CName FinalStepDistanceVar { get; set;}

[REDProp("finalStepActiveVar")]
public CName FinalStepActiveVar { get; set;}

[REDProp("finalStepEvent")]
public CName FinalStepEvent { get; set;}

[REDProp("finalStepActivationNotification")]
public CName FinalStepActivationNotification { get; set;}

[REDProp("finalStepDeactivationNotification")]
public CName FinalStepDeactivationNotification { get; set;}

[REDProp("finalStepDeactivationNotificationTimeOut")]
public float FinalStepDeactivationNotificationTimeOut { get; set;}

[REDProp("finalStepDistanceLimit")]
public float FinalStepDistanceLimit { get; set;}

#endregion
}
}