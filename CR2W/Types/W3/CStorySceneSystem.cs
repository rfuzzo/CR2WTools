using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneSystem : IGameSystem
{
#region RED Properties

[REDProp("activeScenes")]
public Array<Handle<CStoryScenePlayer>> ActiveScenes { get; set;}

[REDProp("actorMap")]
public Ptr<CStorySceneActorMap> ActorMap { get; set;}

#endregion
}
}