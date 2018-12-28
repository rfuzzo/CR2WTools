using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CBoidPointOfInterestComponent : CComponent
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

/*[REDProp("params.m_type")]
public CName Params.m_type { get; set;}

[REDProp("params.m_scale")]
public float Params.m_scale { get; set;}

[REDProp("params.m_gravityRangeMin")]
public float Params.m_gravityRangeMin { get; set;}

[REDProp("params.m_gravityRangeMax")]
public float Params.m_gravityRangeMax { get; set;}

[REDProp("params.m_effectorRadius")]
public float Params.m_effectorRadius { get; set;}*/

[REDProp("acceptor")]
public EZoneAcceptor Acceptor { get; set;}

/*[REDProp("params.m_shapeType")]
public CName Params.m_shapeType { get; set;}

[REDProp("params.m_useReachCallBack")]
public bool Params.m_useReachCallBack { get; set;}

[REDProp("params.m_closestOnly")]
public bool Params.m_closestOnly { get; set;}

[REDProp("params.m_coneMinOpeningAngle")]
public float Params.m_coneMinOpeningAngle { get; set;}

[REDProp("params.m_coneMaxOpeningAngle")]
public float Params.m_coneMaxOpeningAngle { get; set;}

[REDProp("params.m_coneEffectorOpeningAngle")]
public float Params.m_coneEffectorOpeningAngle { get; set;}*/

[REDProp("crawlingSwarmDebug")]
public bool CrawlingSwarmDebug { get; set;}

#endregion
}
}