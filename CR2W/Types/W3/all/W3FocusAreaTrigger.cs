using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3FocusAreaTrigger : CGameplayEntity
{
#region RED Properties

[REDProp("rumbleIntensityModifier")]
public float RumbleIntensityModifier { get; set;}

[REDProp("isDisabled")]
public bool IsDisabled { get; set;}

[REDProp("intensity")]
public float Intensity { get; set;}

[REDProp("isActive")]
public bool IsActive { get; set;}

[REDProp("linkedClues")]
public Array<EntityHandle> LinkedClues { get; set;}

[REDProp("linkedCluesTags")]
public Array<CName> LinkedCluesTags { get; set;}

#endregion
}
}