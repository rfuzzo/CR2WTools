using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CPlayEffectPerformableAction : IEffectManagmentPerformableAction
{
#region RED Properties

[REDProp("entitySelectionType")]
public EEntityTargetingActionMechanism EntitySelectionType { get; set;}

[REDProp("entityHandle")]
public EntityHandle EntityHandle { get; set;}

[REDProp("effectName")]
public CName EffectName { get; set;}

[REDProp("boneName")]
public CName BoneName { get; set;}

#endregion
}
}