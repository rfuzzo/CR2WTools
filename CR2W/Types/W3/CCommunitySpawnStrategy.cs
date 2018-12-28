using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CCommunitySpawnStrategy : CObject
{
#region RED Properties

[REDProp("strategy")]
public Ptr<IEngineSpawnStrategy> Strategy { get; set;}

#endregion
}
}