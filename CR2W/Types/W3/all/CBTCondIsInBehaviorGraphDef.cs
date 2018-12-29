using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondIsInBehaviorGraphDef : IBehTreeConditionalTaskDefinition
{
#region RED Properties

[REDProp("behGraphName")]
public CName BehGraphName { get; set;}

#endregion
}
}