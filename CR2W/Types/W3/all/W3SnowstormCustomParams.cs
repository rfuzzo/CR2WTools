using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SnowstormCustomParams : W3BuffCustomParams
{
#region RED Properties

[REDProp("showCamEffect")]
public bool ShowCamEffect { get; set;}

#endregion
}
}