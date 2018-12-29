using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CReactionLookAtAction : IReactionAction
{
#region RED Properties

[REDProp("lookAtType")]
public EReactionLookAtType LookAtType { get; set;}

#endregion
}
}