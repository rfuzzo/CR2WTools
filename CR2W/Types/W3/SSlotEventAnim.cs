using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SSlotEventAnim 
{
#region RED Properties

[REDProp("event")]
public CName Event { get; set;}

[REDProp("animation")]
public CName Animation { get; set;}

#endregion
}
}