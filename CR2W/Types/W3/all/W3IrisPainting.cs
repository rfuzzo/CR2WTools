using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3IrisPainting : CGameplayEntity
{
#region RED Properties

[REDProp("portalHP")]
public Int32 PortalHP { get; set;}

[REDProp("m_PortalCurrentHP")]
public Int32 M_PortalCurrentHP { get; set;}

[REDProp("m_IsOpen")]
public bool M_IsOpen { get; set;}

[REDProp("m_IsReady")]
public bool M_IsReady { get; set;}

[REDProp("m_ChargingTotalDuration")]
public float M_ChargingTotalDuration { get; set;}

[REDProp("m_ChargingStepDuration")]
public float M_ChargingStepDuration { get; set;}

[REDProp("m_LocktagsOn")]
public bool M_LocktagsOn { get; set;}

#endregion
}
}