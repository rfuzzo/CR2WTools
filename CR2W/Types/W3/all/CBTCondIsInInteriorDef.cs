using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondIsInInteriorDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("testSubject")]
public ETestSubject TestSubject { get; set;}

#endregion
}
}