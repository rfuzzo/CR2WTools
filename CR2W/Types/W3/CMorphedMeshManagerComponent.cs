using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMorphedMeshManagerComponent : CComponent
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

/*[REDProp("Default morph ratio")]
public float Default morph ratio { get; set;}*/

[REDProp("morphCurve")]
public Handle<CCurve> MorphCurve { get; set;}

[REDProp("morphRatio")]
public float MorphRatio { get; set;}

#endregion
}
}