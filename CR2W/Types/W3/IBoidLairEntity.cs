using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class IBoidLairEntity : CGameplayEntity
{
#region RED Properties

[REDProp("tags")]
public TagList Tags { get; set;}

[REDProp("transform")]
public EngineTransform Transform { get; set;}

[REDProp("transformParent")]
public Ptr<CHardAttachment> TransformParent { get; set;}

[REDProp("guid")]
public CGUID Guid { get; set;}

[REDProp("components")]
public Array<Ptr<CComponent>> Components { get; set;}

[REDProp("template")]
public Handle<CEntityTemplate> Template { get; set;}

[REDProp("streamingDataBuffer")]
public SharedDataBuffer StreamingDataBuffer { get; set;}

[REDProp("streamingDistance")]
public byte StreamingDistance { get; set;}

[REDProp("entityStaticFlags")]
public EEntityStaticFlags EntityStaticFlags { get; set;}

[REDProp("autoPlayEffectName")]
public CName AutoPlayEffectName { get; set;}

[REDProp("entityFlags")]
public byte EntityFlags { get; set;}

[REDProp("idTag")]
public IdTag IdTag { get; set;}

[REDProp("isSaveable")]
public bool IsSaveable { get; set;}

[REDProp("propertyAnimationSet")]
public Ptr<CPropertyAnimationSet> PropertyAnimationSet { get; set;}

[REDProp("displayName")]
public LocalizedString DisplayName { get; set;}

[REDProp("stats")]
public Ptr<CCharacterStats> Stats { get; set;}

[REDProp("isInteractionActivator")]
public bool IsInteractionActivator { get; set;}

[REDProp("aimVector")]
public Vector AimVector { get; set;}

[REDProp("gameplayFlags")]
public uint GameplayFlags { get; set;}

[REDProp("focusModeVisibility")]
public EFocusModeVisibility FocusModeVisibility { get; set;}

[REDProp("boidSpeciesName")]
public CName BoidSpeciesName { get; set;}

[REDProp("spawnFrequency")]
public float SpawnFrequency { get; set;}

[REDProp("spawnLimit")]
public int SpawnLimit { get; set;}

[REDProp("totalLifetimeSpawnLimit")]
public int TotalLifetimeSpawnLimit { get; set;}

[REDProp("lairBoundings")]
public EntityHandle LairBoundings { get; set;}

[REDProp("range")]
public float Range { get; set;}

[REDProp("visibilityRange")]
public float VisibilityRange { get; set;}

#endregion
}
}