using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMetalinkWithAIQueueComponent : CMetalinkComponent
{
#region RED Properties

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

[REDProp("transformParent")]
public Ptr<CHardAttachment> TransformParent { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("name")]
public string Name { get; set;}

[REDProp("isStreamed")]
public bool IsStreamed { get; set;}

[REDProp("isVisible")]
public bool IsVisible { get; set;}

[REDProp("icon")]
public Handle<CBitmapTexture> Icon { get; set;}

[REDProp("aiAction")]
public Handle<IAIExplorationTree> AiAction { get; set;}

[REDProp("pathfindingCostMultiplier")]
public float PathfindingCostMultiplier { get; set;}

[REDProp("destinationEntityTag")]
public CName DestinationEntityTag { get; set;}

[REDProp("destinationWaypointComponent")]
public string DestinationWaypointComponent { get; set;}

[REDProp("internalObstacleEntity")]
public EntityHandle InternalObstacleEntity { get; set;}

[REDProp("internalObstacleComponent")]
public string InternalObstacleComponent { get; set;}

[REDProp("useInternalObstacle")]
public bool UseInternalObstacle { get; set;}

[REDProp("enabledByDefault")]
public bool EnabledByDefault { get; set;}

[REDProp("enabled")]
public bool Enabled { get; set;}

[REDProp("isGhostLink")]
public bool IsGhostLink { get; set;}

[REDProp("questTrackingPortal")]
public bool QuestTrackingPortal { get; set;}

#endregion
}
}