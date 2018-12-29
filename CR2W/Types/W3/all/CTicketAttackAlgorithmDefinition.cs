using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CTicketAttackAlgorithmDefinition : CTicketBaseAlgorithmDefinition
{
#region RED Properties

[REDProp("overrideDefaultTicketCount")]
public CBehTreeValBool OverrideDefaultTicketCount { get; set;}

[REDProp("overridenValueWhenInFront")]
public CBehTreeValInt OverridenValueWhenInFront { get; set;}

[REDProp("overridenValueWhenInBack")]
public CBehTreeValInt OverridenValueWhenInBack { get; set;}

[REDProp("invertDistanceImportance")]
public bool InvertDistanceImportance { get; set;}

[REDProp("denyTicketWhenNotInFrame")]
public bool DenyTicketWhenNotInFrame { get; set;}

#endregion
}
}