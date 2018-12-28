using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CCommunitySystem : IGameSystem
{
#region RED Properties

[REDProp("apMan")]
public Handle<CActionPointManager> ApMan { get; set;}

[REDProp("communitySpawnInitializer")]
public Handle<ISpawnTreeInitializerAI> CommunitySpawnInitializer { get; set;}

#endregion
}
}