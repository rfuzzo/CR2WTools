using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CReactionMultiAction : IReactionAction
{
#region RED Properties

[REDProp("actions")]
public Array<Ptr<IReactionAction>> Actions { get; set;}

#endregion
}
}