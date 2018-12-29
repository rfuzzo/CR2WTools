using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SEnumVariant 
{
#region RED Properties

[REDProp("enumType")]
public CName EnumType { get; set;}

[REDProp("enumValue")]
public int EnumValue { get; set;}

#endregion
}
}