using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskReactionToCollisionDef : CBTTaskCollisionMonitorDef
{
#region RED Properties

[REDProp("waitTimeout")]
public float WaitTimeout { get; set;}

[REDProp("activationTimeout")]
public float ActivationTimeout { get; set;}

[REDProp("knockdownDuration")]
public float KnockdownDuration { get; set;}

[REDProp("activationScriptEvent")]
public CName ActivationScriptEvent { get; set;}

[REDProp("deactivateScriptEvent")]
public CName DeactivateScriptEvent { get; set;}

#endregion
}
}