using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CNormalBlendComponent : CComponent
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

[REDProp("dataSource")]
public Ptr<INormalBlendDataSource> DataSource { get; set;}

[REDProp("useMainTick")]
public bool UseMainTick { get; set;}

[REDProp("sourceMaterial")]
public Handle<IMaterial> SourceMaterial { get; set;}

[REDProp("sourceNormalTexture")]
public Handle<ITexture> SourceNormalTexture { get; set;}

[REDProp("normalBlendMaterial")]
public Handle<CMaterialInstance> NormalBlendMaterial { get; set;}

[REDProp("normalBlendAreas")]
public Array<Vector> NormalBlendAreas { get; set;}

#endregion
}
}