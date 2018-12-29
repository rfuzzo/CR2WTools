using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAILeadFormationTree : IAIIdleFormationTree
{
#region RED Properties

[REDProp("leadFormationSteeringGraph")]
public Handle<CMoveSteeringBehavior> LeadFormationSteeringGraph { get; set;}

[REDProp("leadSubtree")]
public Handle<CAIIdleTree> LeadSubtree { get; set;}

#endregion
}
}