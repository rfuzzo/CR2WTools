using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CQuestCameraFocusCondition : IQuestCondition
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("active")]
public bool Active { get; set;}

[REDProp("nodeTag")]
public CName NodeTag { get; set;}

[REDProp("angleTolerance")]
public float AngleTolerance { get; set;}

[REDProp("isLookingAtNode")]
public bool IsLookingAtNode { get; set;}

[REDProp("testLineOfSight")]
public bool TestLineOfSight { get; set;}

[REDProp("lineOfSightSource")]
public ECameraFocusConditionLineOfSightSource LineOfSightSource { get; set;}

#endregion
}
}