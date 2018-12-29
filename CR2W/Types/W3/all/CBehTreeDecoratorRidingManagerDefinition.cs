using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBehTreeDecoratorRidingManagerDefinition : IBehTreeNodeSpecialDefinition
{
#region RED Properties

[REDProp("priority")]
public CBehTreeValInt Priority { get; set;}

[REDProp("child")]
public Ptr<IBehTreeNodeDefinition> Child { get; set;}

[REDProp("mountHorseChild")]
public Ptr<IBehTreeNodeDefinition> MountHorseChild { get; set;}

[REDProp("dismountHorseChild")]
public Ptr<IBehTreeNodeDefinition> DismountHorseChild { get; set;}

[REDProp("mountBoatChild")]
public Ptr<IBehTreeNodeDefinition> MountBoatChild { get; set;}

[REDProp("dismountBoatChild")]
public Ptr<IBehTreeNodeDefinition> DismountBoatChild { get; set;}

#endregion
}
}