using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CSlotFormationLogic : IFormationLogic
{
#region RED Properties

[REDProp("recomputionDelay")]
public float RecomputionDelay { get; set;}

[REDProp("minCatchupDistance")]
public float MinCatchupDistance { get; set;}

[REDProp("formationPattern")]
public Ptr<IFormationPatternNode> FormationPattern { get; set;}

#endregion
}
}