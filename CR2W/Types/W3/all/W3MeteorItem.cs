using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MeteorItem : W3QuestUsableItem
{
#region RED Properties

[REDProp("collisionGroups")]
public Array<CName> CollisionGroups { get; set;}

[REDProp("meteorResourceName")]
public CName MeteorResourceName { get; set;}

[REDProp("meteorEntityTemplate")]
public Handle<CEntityTemplate> MeteorEntityTemplate { get; set;}

#endregion
}
}