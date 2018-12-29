using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondIsInTheWayDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("origin")]
public ETargetName Origin { get; set;}

[REDProp("obstacle")]
public ETargetName Obstacle { get; set;}

[REDProp("destination")]
public ETargetName Destination { get; set;}

[REDProp("requiredDistanceFromLine")]
public float RequiredDistanceFromLine { get; set;}

[REDProp("returnIfInvalid")]
public bool ReturnIfInvalid { get; set;}

#endregion
}
}