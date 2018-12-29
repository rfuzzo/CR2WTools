using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SVitalSpotEnableConditions 
{
#region RED Properties

[REDProp("animationEventName")]
public CName AnimationEventName { get; set;}

[REDProp("VSActivatorBehTreeNodeName")]
public CName VSActivatorBehTreeNodeName { get; set;}

[REDProp("enableByDefault")]
public bool EnableByDefault { get; set;}

#endregion
}
}