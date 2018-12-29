using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskActivateOnlyOnceDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("successOnly")]
public bool SuccessOnly { get; set;}

[REDProp("resetWhenReattachFromPool")]
public bool ResetWhenReattachFromPool { get; set;}

[REDProp("resetOnGameplayEvent")]
public CName ResetOnGameplayEvent { get; set;}

#endregion
}
}