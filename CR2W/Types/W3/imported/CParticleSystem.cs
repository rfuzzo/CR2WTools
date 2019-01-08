using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CParticleSystem : CResource
{
#region RED Properties

[REDProp("previewBackgroundColor")]
public Color PreviewBackgroundColor { get; set;}

[REDProp("previewShowGrid")]
public bool PreviewShowGrid { get; set;}

[REDProp("visibleThroughWalls")]
public bool VisibleThroughWalls { get; set;}

[REDProp("prewarmingTime")]
public float PrewarmingTime { get; set;}

[REDProp("emitters", 2,0)]
public Array<Ptr<CParticleEmitter>> Emitters { get; set;}

[REDProp("lods", 2,0)]
public Array<SParticleSystemLODLevel> Lods { get; set;}

[REDProp("autoHideDistance")]
public float AutoHideDistance { get; set;}

[REDProp("autoHideRange")]
public float AutoHideRange { get; set;}

[REDProp("renderingPlane")]
public ERenderingPlane RenderingPlane { get; set;}

#endregion
}
}