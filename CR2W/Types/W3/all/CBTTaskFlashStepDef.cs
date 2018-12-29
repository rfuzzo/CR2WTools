using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskFlashStepDef : IBehTreeTaskDefinition
{
#region RED Properties

[REDProp("minDistance")]
public float MinDistance { get; set;}

[REDProp("maxDistance")]
public float MaxDistance { get; set;}

[REDProp("cooldown")]
public float Cooldown { get; set;}

[REDProp("teleportEventName")]
public CName TeleportEventName { get; set;}

[REDProp("disallowInPlayerFOV")]
public bool DisallowInPlayerFOV { get; set;}

[REDProp("teleportOutsidePlayerFOV")]
public bool TeleportOutsidePlayerFOV { get; set;}

[REDProp("teleportType")]
public ETeleportType TeleportType { get; set;}

[REDProp("disappearfxName")]
public CName DisappearfxName { get; set;}

[REDProp("appearFXName")]
public CName AppearFXName { get; set;}

#endregion
}
}