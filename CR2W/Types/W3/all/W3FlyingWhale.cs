using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3FlyingWhale : CActor
{
#region RED Properties

[REDProp("forcedAppearance")]
public string ForcedAppearance { get; set;}

#endregion
}
}