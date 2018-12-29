using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskDrawItemDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("itemName")]
public CName ItemName { get; set;}

[REDProp("eventName")]
public CName EventName { get; set;}

#endregion
}
}