using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CCommunityInitializers : CObject
{
#region RED Properties

[REDProp("initializers")]
public Array<Ptr<ISpawnTreeInitializer>> Initializers { get; set;}

#endregion
}
}