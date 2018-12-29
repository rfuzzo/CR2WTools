using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeBehaviorGraphDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("graph")]
public Handle<CBTEnumBehaviorGraph> Graph { get; set;}

[REDProp("forceHighPriority")]
public CBehTreeValBool ForceHighPriority { get; set;}

#endregion
}
}