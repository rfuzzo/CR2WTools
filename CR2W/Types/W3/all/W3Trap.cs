using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Trap : W3MonsterClue
{
#region RED Properties

[REDProp("ARM_INTERACTION_COMPONENT_NAME")]
public string ARM_INTERACTION_COMPONENT_NAME { get; set;}

[REDProp("DISARM_INTERACTION_COMPONENT_NAME")]
public string DISARM_INTERACTION_COMPONENT_NAME { get; set;}

[REDProp("m_IsActive")]
public bool M_IsActive { get; set;}

[REDProp("m_Targets")]
public Array<Handle<CNode>> M_Targets { get; set;}

[REDProp("m_isArmed")]
public bool M_isArmed { get; set;}

[REDProp("m_wasSprung")]
public bool M_wasSprung { get; set;}

[REDProp("m_isPlayingAnimation")]
public bool M_isPlayingAnimation { get; set;}

[REDProp("activeByDefault")]
public bool ActiveByDefault { get; set;}

[REDProp("factOnArm")]
public SFactParameters FactOnArm { get; set;}

[REDProp("factOnDisarm")]
public SFactParameters FactOnDisarm { get; set;}

[REDProp("factOnActivation")]
public SFactParameters FactOnActivation { get; set;}

[REDProp("factOnDeactivation")]
public SFactParameters FactOnDeactivation { get; set;}

[REDProp("deactivateAfterTime")]
public float DeactivateAfterTime { get; set;}

[REDProp("appearanceActivated")]
public string AppearanceActivated { get; set;}

[REDProp("appearanceDeactived")]
public string AppearanceDeactived { get; set;}

[REDProp("appearanceArmed")]
public string AppearanceArmed { get; set;}

[REDProp("appearanceDisarmed")]
public string AppearanceDisarmed { get; set;}

[REDProp("canBeArmed")]
public bool CanBeArmed { get; set;}

[REDProp("interactibleAfterSprung")]
public bool InteractibleAfterSprung { get; set;}

[REDProp("willActivateWhenHit")]
public bool WillActivateWhenHit { get; set;}

[REDProp("soundOnArm")]
public CName SoundOnArm { get; set;}

[REDProp("soundOnDisarm")]
public CName SoundOnDisarm { get; set;}

#endregion
}
}