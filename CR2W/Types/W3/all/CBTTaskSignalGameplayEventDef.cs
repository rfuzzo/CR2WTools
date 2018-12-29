using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskSignalGameplayEventDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("eventName")]
public CName EventName { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onSuccess")]
public bool OnSuccess { get; set;}

[REDProp("onTaggedEntity")]
public bool OnTaggedEntity { get; set;}

[REDProp("tagToFind")]
public CName TagToFind { get; set;}

#endregion
}
}