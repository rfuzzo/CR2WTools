using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeValEHorseMoveType 
{
#region RED Properties

[REDProp("varName")]
public CName VarName { get; set;}

[REDProp("value")]
public EHorseMoveType Value { get; set;}

#endregion
}
}