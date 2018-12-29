using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CTicketAttackAlgorithm : CTicketBaseAlgorithm
{
#region RED Properties

[REDProp("invertDistanceImportance")]
public bool InvertDistanceImportance { get; set;}

[REDProp("overrideDefaultTicketCount")]
public bool OverrideDefaultTicketCount { get; set;}

[REDProp("overridenValueWhenInFront")]
public Int32 OverridenValueWhenInFront { get; set;}

[REDProp("overridenValueWhenInBack")]
public Int32 OverridenValueWhenInBack { get; set;}

[REDProp("denyTicketWhenNotInFrame")]
public bool DenyTicketWhenNotInFrame { get; set;}

#endregion
}
}