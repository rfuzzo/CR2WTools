using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondIsInStateDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("stateName")]
public CName StateName { get; set;}

[REDProp("ifNot")]
public bool IfNot { get; set;}

#endregion
}
}