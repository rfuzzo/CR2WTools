using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBehTreeDecoratorFindDestinationItemStoreDefinition : CBehTreeDecoratorCarryingItemsBaseDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("carryingAreaName_var")]
public CName CarryingAreaName_var { get; set;}

[REDProp("storeTag")]
public CBehTreeValCName StoreTag { get; set;}

#endregion
}
}