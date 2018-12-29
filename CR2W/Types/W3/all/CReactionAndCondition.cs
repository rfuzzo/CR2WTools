using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CReactionAndCondition : IReactionCondition
{
#region RED Properties

[REDProp("conditions")]
public Array<Ptr<IReactionCondition>> Conditions { get; set;}

#endregion
}
}