using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3DamageAreaTrigger : CEntity
{
#region RED Properties

[REDProp("onlyAffectsPlayer")]
public bool OnlyAffectsPlayer { get; set;}

[REDProp("activateOnce")]
public bool ActivateOnce { get; set;}

[REDProp("checkTag")]
public bool CheckTag { get; set;}

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

[REDProp("actorTag")]
public CName ActorTag { get; set;}

[REDProp("excludedActorsTags")]
public Array<CName> ExcludedActorsTags { get; set;}

[REDProp("damage")]
public float Damage { get; set;}

[REDProp("useDamageFromXML")]
public CName UseDamageFromXML { get; set;}

[REDProp("damageFromFXDelay")]
public float DamageFromFXDelay { get; set;}

[REDProp("areaRadius")]
public float AreaRadius { get; set;}

[REDProp("attackInterval")]
public float AttackInterval { get; set;}

[REDProp("preAttackDuration")]
public float PreAttackDuration { get; set;}

[REDProp("externalFXEntityTag")]
public CName ExternalFXEntityTag { get; set;}

[REDProp("externalFXName")]
public CName ExternalFXName { get; set;}

[REDProp("attackFX")]
public CName AttackFX { get; set;}

[REDProp("preAttackFX")]
public CName PreAttackFX { get; set;}

[REDProp("attackFXEntity")]
public Handle<CEntityTemplate> AttackFXEntity { get; set;}

[REDProp("soundFX")]
public string SoundFX { get; set;}

[REDProp("immunityFact")]
public string ImmunityFact { get; set;}

[REDProp("damageType")]
public ETriggeredDamageType DamageType { get; set;}

[REDProp("action")]
public Handle<W3DamageAction> Action { get; set;}

[REDProp("affectedEntity")]
public Handle<CEntity> AffectedEntity { get; set;}

[REDProp("fxEntity")]
public Handle<CEntity> FxEntity { get; set;}

[REDProp("activated")]
public bool Activated { get; set;}

[REDProp("dummyGameplayEntity")]
public Handle<CGameplayEntity> DummyGameplayEntity { get; set;}

[REDProp("victim")]
public Handle<CActor> Victim { get; set;}

[REDProp("externalFXEntity")]
public Handle<CEntity> ExternalFXEntity { get; set;}

[REDProp("pos")]
public Vector Pos { get; set;}

#endregion
}
}