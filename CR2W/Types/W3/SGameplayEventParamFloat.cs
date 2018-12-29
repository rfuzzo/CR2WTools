using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SGameplayEventParamFloat 
{
#region RED Properties

[REDProp("value")]
public float Value { get; set;}

#endregion
}
}