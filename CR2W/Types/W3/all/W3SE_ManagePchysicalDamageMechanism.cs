using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3SE_ManagePchysicalDamageMechanism : W3SwitchEvent
{
#region RED Properties

[REDProp("mechanismHandle")]
public Array<EntityHandle> MechanismHandle { get; set;}

[REDProp("mechanismTag")]
public CName MechanismTag { get; set;}

[REDProp("operations")]
public Array<EPhysicalDamagemechanismOperation> Operations { get; set;}

#endregion
}
}