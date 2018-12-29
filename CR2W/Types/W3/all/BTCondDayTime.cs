using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTCondDayTime : IBehTreeTask
{
#region RED Properties

[REDProp("validTimeStart")]
public Int32 ValidTimeStart { get; set;}

[REDProp("validTimeEnd")]
public Int32 ValidTimeEnd { get; set;}

#endregion
}
}