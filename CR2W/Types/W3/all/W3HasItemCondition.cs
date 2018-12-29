using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3HasItemCondition : ISpawnScriptCondition
{
#region RED Properties

[REDProp("item")]
public SItemNameProperty Item { get; set;}

[REDProp("actorTag")]
public CName ActorTag { get; set;}

#endregion
}
}