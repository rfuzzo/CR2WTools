using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationComponent : CComponent
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

[REDProp("explorationId")]
public EExplorationType ExplorationId { get; set;}

[REDProp("start")]
public Vector Start { get; set;}

[REDProp("end")]
public Vector End { get; set;}

[REDProp("componentForEvents")]
public string ComponentForEvents { get; set;}

[REDProp("internalExploration")]
public bool InternalExploration { get; set;}

#endregion
}
}