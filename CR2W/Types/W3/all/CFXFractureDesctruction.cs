using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFXFractureDesctruction : IFXPhysicalForce
{
#region RED Properties

[REDProp("fieldType")]
public EFieldType FieldType { get; set;}

[REDProp("simulateLocalyInEntity")]
public bool SimulateLocalyInEntity { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

#endregion
}
}