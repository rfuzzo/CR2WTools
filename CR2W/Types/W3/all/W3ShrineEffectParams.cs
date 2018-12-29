using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ShrineEffectParams : W3BuffCustomParams
{
#region RED Properties

[REDProp("isFromMutagen23")]
public bool IsFromMutagen23 { get; set;}

#endregion
}
}