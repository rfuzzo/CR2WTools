using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SReward 
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("experience")]
public int Experience { get; set;}

[REDProp("level")]
public int Level { get; set;}

[REDProp("gold")]
public int Gold { get; set;}

[REDProp("items")]
public Array<SItemReward> Items { get; set;}

[REDProp("achievement")]
public int Achievement { get; set;}

[REDProp("script")]
public CName Script { get; set;}

[REDProp("comment")]
public string Comment { get; set;}

#endregion
}
}