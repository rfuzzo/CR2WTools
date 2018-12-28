using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class IFXPhysicalForce : CObject
{
#region RED Properties

[REDProp("fieldType")]
public EFieldType FieldType { get; set;}

[REDProp("simulateLocalyInEntity")]
public bool SimulateLocalyInEntity { get; set;}

#endregion
}
}