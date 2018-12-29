using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CCustomBehTreeActorLatentAction : IActorLatentAction
{
#region RED Properties

[REDProp("behTree")]
public Ptr<IBehTreeNodeDefinition> BehTree { get; set;}

#endregion
}
}