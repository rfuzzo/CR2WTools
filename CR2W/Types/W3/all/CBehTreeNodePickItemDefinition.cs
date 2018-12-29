using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeNodePickItemDefinition : CBehTreeNodeCarryingItemBaseDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("rBoneToAttachItem")]
public CBehTreeValCName RBoneToAttachItem { get; set;}

[REDProp("lBoneToAttachItem")]
public CBehTreeValCName LBoneToAttachItem { get; set;}

#endregion
}
}