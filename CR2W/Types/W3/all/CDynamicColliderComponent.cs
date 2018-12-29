using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CDynamicColliderComponent : CComponent
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

[REDProp("useInWaterNormal")]
public bool UseInWaterNormal { get; set;}

[REDProp("useInWaterDisplacement")]
public bool UseInWaterDisplacement { get; set;}

[REDProp("useInGrassDisplacement")]
public bool UseInGrassDisplacement { get; set;}

[REDProp("useHideFactor")]
public bool UseHideFactor { get; set;}

#endregion
}
}