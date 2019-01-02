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
public class CCollisionMesh : CResource
{
#region RED Properties

[REDProp("shapes", 2,0)]
public Array<Ptr<ICollisionShape>> Shapes { get; set;}

[REDProp("occlusionAttenuation")]
public float OcclusionAttenuation { get; set;}

[REDProp("occlusionDiagonalLimit")]
public float OcclusionDiagonalLimit { get; set;}

[REDProp("swimmingRotationAxis")]
public Int32 SwimmingRotationAxis { get; set;}

#endregion
}
}