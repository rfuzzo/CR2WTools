using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CStorySceneProp : IStorySceneItem
{
#region RED Properties

[REDProp("id")]
public CName Id { get; set;}

[REDProp("entityTemplate")]
public Soft<CEntityTemplate> EntityTemplate { get; set;}

[REDProp("forceBehaviorGraph")]
public CName ForceBehaviorGraph { get; set;}

[REDProp("resetBehaviorGraph")]
public bool ResetBehaviorGraph { get; set;}

[REDProp("useMimics")]
public bool UseMimics { get; set;}

#endregion
}
}