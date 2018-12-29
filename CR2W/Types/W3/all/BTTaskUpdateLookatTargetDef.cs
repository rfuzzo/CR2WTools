using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskUpdateLookatTargetDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("useCombatTarget")]
public bool UseCombatTarget { get; set;}

[REDProp("headBoneName")]
public CName HeadBoneName { get; set;}

[REDProp("usePrediction")]
public bool UsePrediction { get; set;}

[REDProp("useCustomTarget")]
public bool UseCustomTarget { get; set;}

[REDProp("addZOffsetValue")]
public bool AddZOffsetValue { get; set;}

[REDProp("disableLookAtOnDeath")]
public bool DisableLookAtOnDeath { get; set;}

[REDProp("disableLookAtOnDeactivate")]
public bool DisableLookAtOnDeactivate { get; set;}

#endregion
}
}