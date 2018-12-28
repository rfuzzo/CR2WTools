using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CAITree : IAITree
{
#region RED Properties

[REDProp("aiTreeName")]
public string AiTreeName { get; set;}

[REDProp("tree")]
public Handle<CBehTree> Tree { get; set;}

#endregion
}
}