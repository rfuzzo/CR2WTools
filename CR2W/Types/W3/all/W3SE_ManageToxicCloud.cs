using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_ManageToxicCloud : W3SwitchEvent
{
#region RED Properties

[REDProp("entityTag")]
public CName EntityTag { get; set;}

[REDProp("operations")]
public Array<EToxicCloudOperation> Operations { get; set;}

#endregion
}
}