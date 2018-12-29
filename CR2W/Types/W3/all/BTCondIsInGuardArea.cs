using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondIsInGuardArea : IBehTreeTask
{
#region RED Properties

[REDProp("position")]
public ETargetName Position { get; set;}

[REDProp("namedTarget")]
public CName NamedTarget { get; set;}

[REDProp("valueToReturnIfNoGA")]
public bool ValueToReturnIfNoGA { get; set;}

#endregion
}
}