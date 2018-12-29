using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class SCustomMapPinDefinition 
{
#region RED Properties

[REDProp("tag")]
public CName Tag { get; set;}

[REDProp("type")]
public CName Type { get; set;}

#endregion
}
}