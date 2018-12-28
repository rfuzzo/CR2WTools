using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CHeadManagerComponent : CSelfUpdatingComponent
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

[REDProp("tickGroup")]
public ETickGroup TickGroup { get; set;}

[REDProp("tickedByDefault")]
public bool TickedByDefault { get; set;}

[REDProp("timePeriod")]
public GameTime TimePeriod { get; set;}

[REDProp("initHeadIndex")]
public int InitHeadIndex { get; set;}

[REDProp("lastChangeGameTime")]
public GameTime LastChangeGameTime { get; set;}

[REDProp("hasTattoo")]
public bool HasTattoo { get; set;}

[REDProp("hasDemonMark")]
public bool HasDemonMark { get; set;}

[REDProp("curIndex")]
public uint CurIndex { get; set;}

[REDProp("heads")]
public Array<CName> Heads { get; set;}

[REDProp("headsWithTattoo")]
public Array<CName> HeadsWithTattoo { get; set;}

[REDProp("headsDemon")]
public Array<CName> HeadsDemon { get; set;}

[REDProp("headsDemonWithTattoo")]
public Array<CName> HeadsDemonWithTattoo { get; set;}

[REDProp("curHeadId")]
public SItemUniqueId CurHeadId { get; set;}

[REDProp("blockGrowing")]
public bool BlockGrowing { get; set;}

#endregion
}
}