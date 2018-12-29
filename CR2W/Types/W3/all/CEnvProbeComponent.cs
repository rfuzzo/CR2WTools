using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CEnvProbeComponent : CComponent
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

[REDProp("contribution")]
public float Contribution { get; set;}

[REDProp("nestingLevel")]
public uint NestingLevel { get; set;}

[REDProp("effectIntensity")]
public float EffectIntensity { get; set;}

[REDProp("areaMarginFactor")]
public Vector AreaMarginFactor { get; set;}

[REDProp("areaDisplace")]
public Vector AreaDisplace { get; set;}

[REDProp("isParallaxCorrected")]
public bool IsParallaxCorrected { get; set;}

[REDProp("parallaxTransform")]
public EngineTransform ParallaxTransform { get; set;}

[REDProp("genParams")]
public SEnvProbeGenParams GenParams { get; set;}

/*[REDProp("textureCacheHashes")]
public Static<4,uint> TextureCacheHashes { get; set;}*/

#endregion
}
}