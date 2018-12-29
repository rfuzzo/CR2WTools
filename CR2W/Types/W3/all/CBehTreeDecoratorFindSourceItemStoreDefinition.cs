using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeDecoratorFindSourceItemStoreDefinition : CBehTreeDecoratorCarryingItemsBaseDefinition
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