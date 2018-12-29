using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3IllusionaryObstacle : CGameplayEntity
{
#region RED Properties

[REDProp("focusAreaIntensity")]
public float FocusAreaIntensity { get; set;}

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

[REDProp("m_disappearanceEffectDuration")]
public float M_disappearanceEffectDuration { get; set;}

[REDProp("m_addFactOnDispel")]
public string M_addFactOnDispel { get; set;}

[REDProp("m_addFactOnDiscovery")]
public string M_addFactOnDiscovery { get; set;}

[REDProp("discoveryOnelinerTag")]
public string DiscoveryOnelinerTag { get; set;}

[REDProp("m_discoveryOneliner")]
public EIllusionDiscoveredOneliner M_discoveryOneliner { get; set;}

[REDProp("m_illusionDiscoveredEver")]
public bool M_illusionDiscoveredEver { get; set;}

[REDProp("m_illusionDiscoveredThisSession")]
public bool M_illusionDiscoveredThisSession { get; set;}

[REDProp("interactionComponent")]
public Handle<CInteractionComponent> InteractionComponent { get; set;}

[REDProp("meshComponent")]
public Handle<CMeshComponent> MeshComponent { get; set;}

[REDProp("m_effectRange")]
public float M_effectRange { get; set;}

[REDProp("m_wasDestroyed")]
public bool M_wasDestroyed { get; set;}

[REDProp("m_illusionSpawner")]
public Handle<W3IllusionSpawner> M_illusionSpawner { get; set;}

[REDProp("isFocusAreaActive")]
public bool IsFocusAreaActive { get; set;}

[REDProp("focusModeHighlight")]
public EFocusModeVisibility FocusModeHighlight { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

[REDProp("l_entitiesAround")]
public Array<Handle<CGameplayEntity>> L_entitiesAround { get; set;}

[REDProp("l_illusion")]
public Handle<W3IllusionaryObstacle> L_illusion { get; set;}

[REDProp("saveLockID")]
public Int32 SaveLockID { get; set;}

#endregion
}
}