using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CEnableEncounterAction : IEntityTargetingAction
{
#region RED Properties

[REDProp("entitySelectionType")]
public EEntityTargetingActionMechanism EntitySelectionType { get; set;}

[REDProp("entityHandle")]
public EntityHandle EntityHandle { get; set;}

[REDProp("enable")]
public bool Enable { get; set;}

#endregion
}
}