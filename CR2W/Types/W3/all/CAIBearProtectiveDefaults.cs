using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIBearProtectiveDefaults : CAIBearDefaults
{
#region RED Properties

[REDProp("canTaunt")]
public bool CanTaunt { get; set;}

[REDProp("berserk")]
public bool Berserk { get; set;}

#endregion
}
}