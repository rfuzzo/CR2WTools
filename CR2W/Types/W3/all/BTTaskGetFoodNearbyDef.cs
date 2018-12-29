using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskGetFoodNearbyDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("corpse")]
public CBehTreeValBool Corpse { get; set;}

[REDProp("meat")]
public CBehTreeValBool Meat { get; set;}

[REDProp("vegetable")]
public CBehTreeValBool Vegetable { get; set;}

[REDProp("water")]
public CBehTreeValBool Water { get; set;}

[REDProp("monster")]
public CBehTreeValBool Monster { get; set;}

[REDProp("completeIfTargetChange")]
public bool CompleteIfTargetChange { get; set;}

#endregion
}
}