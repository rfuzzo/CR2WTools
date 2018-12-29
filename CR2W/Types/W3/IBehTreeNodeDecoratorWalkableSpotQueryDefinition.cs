using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class IBehTreeNodeDecoratorWalkableSpotQueryDefinition : IBehTreeNodeDecoratorAsyncQueryDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("queryName")]
public CName QueryName { get; set;}

[REDProp("queryValidFor")]
public float QueryValidFor { get; set;}

[REDProp("useCombatTargetAsReference")]
public bool UseCombatTargetAsReference { get; set;}

[REDProp("useTargetAsSourceSpot")]
public bool UseTargetAsSourceSpot { get; set;}

[REDProp("stayInGuardArea")]
public bool StayInGuardArea { get; set;}

#endregion
}
}