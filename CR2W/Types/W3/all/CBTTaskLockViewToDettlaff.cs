using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskLockViewToDettlaff : IBehTreeTask
{
#region RED Properties

[REDProp("actor")]
public Handle<CActor> Actor { get; set;}

[REDProp("lock")]
public bool Lock { get; set;}

#endregion
}
}