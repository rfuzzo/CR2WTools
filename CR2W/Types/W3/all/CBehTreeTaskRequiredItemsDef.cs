using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeTaskRequiredItemsDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("LeftItemType")]
public CBehTreeValCName LeftItemType { get; set;}

[REDProp("RightItemType")]
public CBehTreeValCName RightItemType { get; set;}

[REDProp("chooseSilverIfPossible")]
public CBehTreeValBool ChooseSilverIfPossible { get; set;}

[REDProp("destroyProjectileOnDeactivate")]
public bool DestroyProjectileOnDeactivate { get; set;}

#endregion
}
}