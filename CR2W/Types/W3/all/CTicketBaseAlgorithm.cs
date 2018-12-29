using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CTicketBaseAlgorithm : ITicketAlgorithmScript
{
#region RED Properties

[REDProp("resetImportanceOnSpecialCombatAction")]
public bool ResetImportanceOnSpecialCombatAction { get; set;}

[REDProp("threatLevelBonus")]
public float ThreatLevelBonus { get; set;}

[REDProp("activationBonus")]
public float ActivationBonus { get; set;}

#endregion
}
}