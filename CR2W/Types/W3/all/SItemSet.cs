using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SItemSet 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("parts")]
public Array<CName> Parts { get; set;}

[REDProp("abilities")]
public Array<CName> Abilities { get; set;}

#endregion
}
}