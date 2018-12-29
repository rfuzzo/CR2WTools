using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SignOwnerBTTaskCastSign : W3SignOwner
{
#region RED Properties

[REDProp("btTask")]
public Handle<CBTTaskCastSign> BtTask { get; set;}

#endregion
}
}