using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondIsInStanceDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("currStance")]
public ENpcStance CurrStance { get; set;}

[REDProp("ifNot")]
public bool IfNot { get; set;}

#endregion
}
}