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
public class CParticleDrawerMesh : IParticleDrawer
{
#region RED Properties

[REDProp("meshes", 2,0)]
public Array<Handle<CMesh>> Meshes { get; set;}

[REDProp("orientationMode")]
public EMeshParticleOrientationMode OrientationMode { get; set;}

[REDProp("lightChannels")]
public ELightChannel LightChannels { get; set;}

#endregion
}
}