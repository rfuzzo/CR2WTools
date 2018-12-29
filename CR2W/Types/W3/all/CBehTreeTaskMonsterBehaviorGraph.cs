using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeTaskMonsterBehaviorGraph : IBehTreeTask
{
#region RED Properties

[REDProp("graphName")]
public CName GraphName { get; set;}

[REDProp("res")]
public bool Res { get; set;}

[REDProp("owner")]
public Handle<CNewNPC> Owner { get; set;}

#endregion
}
}