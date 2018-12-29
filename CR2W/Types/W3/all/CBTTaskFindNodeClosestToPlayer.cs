using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFindNodeClosestToPlayer : IBehTreeTask
{
#region RED Properties

[REDProp("nodeTag")]
public CName NodeTag { get; set;}

[REDProp("range")]
public float Range { get; set;}

#endregion
}
}