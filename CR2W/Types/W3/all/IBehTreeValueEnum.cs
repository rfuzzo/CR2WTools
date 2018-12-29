using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class IBehTreeValueEnum : IScriptable
{
#region RED Properties

[REDProp("varName")]
public CName VarName { get; set;}

#endregion
}
}