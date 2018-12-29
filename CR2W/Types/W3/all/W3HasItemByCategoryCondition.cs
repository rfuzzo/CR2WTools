using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3HasItemByCategoryCondition : ISpawnScriptCondition
{
#region RED Properties

[REDProp("itemCategory")]
public CName ItemCategory { get; set;}

[REDProp("actorTag")]
public CName ActorTag { get; set;}

#endregion
}
}