using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskEnableLookAtDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("useReactionTarget")]
public bool UseReactionTarget { get; set;}

[REDProp("useActionTarget")]
public bool UseActionTarget { get; set;}

[REDProp("useAsDecorator")]
public bool UseAsDecorator { get; set;}

#endregion
}
}