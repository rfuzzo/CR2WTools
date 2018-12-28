using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CParticleDrawerMesh : IParticleDrawer
{
#region RED Properties

[REDProp("meshes")]
public Array<Handle<CMesh>> Meshes { get; set;}

[REDProp("orientationMode")]
public EMeshParticleOrientationMode OrientationMode { get; set;}

[REDProp("lightChannels")]
public ELightChannel LightChannels { get; set;}

#endregion
}
}