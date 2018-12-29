using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskGameplayEventListenerDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("gameplayEventName")]
public CBehTreeValCName GameplayEventName { get; set;}

[REDProp("validFor")]
public float ValidFor { get; set;}

[REDProp("activeFor")]
public float ActiveFor { get; set;}

[REDProp("clearOnEvent")]
public CName ClearOnEvent { get; set;}

#endregion
}
}