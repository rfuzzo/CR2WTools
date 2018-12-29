using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTCondHorseIsNervous : IBehTreeTask
{
#region RED Properties

[REDProp("isNervous")]
public bool IsNervous { get; set;}

[REDProp("waitForAxiiCalmDownEnd")]
public bool WaitForAxiiCalmDownEnd { get; set;}

#endregion
}
}