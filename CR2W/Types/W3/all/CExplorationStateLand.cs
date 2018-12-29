using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CExplorationStateLand : CExplorationStateAbstract
{
#region RED Properties

[REDProp("m_BehLandRunS")]
public CName M_BehLandRunS { get; set;}

[REDProp("m_LandRunInputAngleF")]
public float M_LandRunInputAngleF { get; set;}

[REDProp("m_BehLandTypeS")]
public CName M_BehLandTypeS { get; set;}

[REDProp("m_BehLandCancelN")]
public CName M_BehLandCancelN { get; set;}

[REDProp("m_BehLandCanEndN")]
public CName M_BehLandCanEndN { get; set;}

[REDProp("m_BehLandSkipToRunN")]
public CName M_BehLandSkipToRunN { get; set;}

[REDProp("m_BehLandSkipToWalkN")]
public CName M_BehLandSkipToWalkN { get; set;}

[REDProp("m_BehLandSkipToIdleN")]
public CName M_BehLandSkipToIdleN { get; set;}

[REDProp("m_BehLandFallForwardN")]
public CName M_BehLandFallForwardN { get; set;}

[REDProp("m_HeightToLandCrouch")]
public float M_HeightToLandCrouch { get; set;}

[REDProp("m_LandTypeE")]
public ELandType M_LandTypeE { get; set;}

[REDProp("m_LandDataIdle")]
public SLandData M_LandDataIdle { get; set;}

[REDProp("m_LandDataWalk")]
public SLandData M_LandDataWalk { get; set;}

[REDProp("m_LandDataWalkHigh")]
public SLandData M_LandDataWalkHigh { get; set;}

[REDProp("m_LandDataRun")]
public SLandData M_LandDataRun { get; set;}

[REDProp("m_LandDataSprint")]
public SLandData M_LandDataSprint { get; set;}

[REDProp("m_LandDataHigher")]
public SLandData M_LandDataHigher { get; set;}

[REDProp("m_LandDataAirCollision")]
public SLandData M_LandDataAirCollision { get; set;}

[REDProp("m_LandDataCrouch")]
public SLandData M_LandDataCrouch { get; set;}

[REDProp("m_LandDataFall")]
public SLandData M_LandDataFall { get; set;}

[REDProp("m_LandDataDamage")]
public SLandData M_LandDataDamage { get; set;}

[REDProp("m_LandDataDeath")]
public SLandData M_LandDataDeath { get; set;}

[REDProp("m_LandDataKnockBack")]
public SLandData M_LandDataKnockBack { get; set;}

[REDProp("m_LandData")]
public SLandData M_LandData { get; set;}

[REDProp("m_UseBendAddOnLand")]
public bool M_UseBendAddOnLand { get; set;}

[REDProp("m_AutoRollB")]
public bool M_AutoRollB { get; set;}

[REDProp("m_AutoSlopeAngleB")]
public float M_AutoSlopeAngleB { get; set;}

[REDProp("m_AutoRollSlopeCoefF")]
public float M_AutoRollSlopeCoefF { get; set;}

[REDProp("m_DamageOverridesRollB")]
public bool M_DamageOverridesRollB { get; set;}

[REDProp("m_RollingB")]
public bool M_RollingB { get; set;}

[REDProp("m_RollIsSlopeB")]
public bool M_RollIsSlopeB { get; set;}

[REDProp("m_RollMinHeightF")]
public float M_RollMinHeightF { get; set;}

[REDProp("m_RollTimeAfterF")]
public float M_RollTimeAfterF { get; set;}

[REDProp("m_RollMinJumpTotalF")]
public float M_RollMinJumpTotalF { get; set;}

[REDProp("m_SlidingB")]
public bool M_SlidingB { get; set;}

[REDProp("m_SlideCheckedSecondFrameB")]
public bool M_SlideCheckedSecondFrameB { get; set;}

[REDProp("m_SlideSavingVelocityV")]
public Vector M_SlideSavingVelocityV { get; set;}

[REDProp("m_AllowHigherJumpB")]
public bool M_AllowHigherJumpB { get; set;}

[REDProp("m_HighLandingHeightF")]
public float M_HighLandingHeightF { get; set;}

[REDProp("m_AllowSkipB")]
public bool M_AllowSkipB { get; set;}

[REDProp("m_RunCoefF")]
public float M_RunCoefF { get; set;}

[REDProp("m_FallIsForwardB")]
public bool M_FallIsForwardB { get; set;}

[REDProp("m_ToFallB")]
public bool M_ToFallB { get; set;}

[REDProp("m_ReadyToEndB")]
public bool M_ReadyToEndB { get; set;}

#endregion
}
}