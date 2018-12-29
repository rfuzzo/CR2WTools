using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SliderPopupData : TextPopupData
{
#region RED Properties

[REDProp("minValue")]
public Int32 MinValue { get; set;}

[REDProp("maxValue")]
public Int32 MaxValue { get; set;}

[REDProp("currentValue")]
public Int32 CurrentValue { get; set;}

#endregion
}
}