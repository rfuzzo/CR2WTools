using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskDeactivateMagicBubble : IBehTreeTask
{
#region RED Properties

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("onAnimEvent")]
public bool OnAnimEvent { get; set;}

[REDProp("animEventName")]
public CName AnimEventName { get; set;}

#endregion
}
}