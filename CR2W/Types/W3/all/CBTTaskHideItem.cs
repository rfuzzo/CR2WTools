using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskHideItem : IBehTreeTask
{
#region RED Properties

[REDProp("owner")]
public Handle<CNewNPC> Owner { get; set;}

[REDProp("eventName")]
public CName EventName { get; set;}

#endregion
}
}