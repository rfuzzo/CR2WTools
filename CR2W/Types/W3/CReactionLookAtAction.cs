using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CReactionLookAtAction : IReactionAction
{
#region RED Properties

[REDProp("lookAtType")]
public EReactionLookAtType LookAtType { get; set;}

#endregion
}
}