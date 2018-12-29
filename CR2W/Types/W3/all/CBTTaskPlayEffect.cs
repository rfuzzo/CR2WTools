using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBTTaskPlayEffect : IBehTreeTask
{
#region RED Properties

[REDProp("effectName")]
public CName EffectName { get; set;}

[REDProp("sfxInsteadOfVfx")]
public bool SfxInsteadOfVfx { get; set;}

[REDProp("owner")]
public Handle<CNewNPC> Owner { get; set;}

[REDProp("onTarget")]
public bool OnTarget { get; set;}

[REDProp("onActionTarget")]
public bool OnActionTarget { get; set;}

[REDProp("onWeaponItem")]
public bool OnWeaponItem { get; set;}

[REDProp("turnOff")]
public bool TurnOff { get; set;}

[REDProp("connectEffectWithTarget")]
public bool ConnectEffectWithTarget { get; set;}

[REDProp("connectWithActionTarget")]
public bool ConnectWithActionTarget { get; set;}

[REDProp("playEffectOnComponent")]
public bool PlayEffectOnComponent { get; set;}

[REDProp("componentName")]
public CName ComponentName { get; set;}

[REDProp("onAnimEvent")]
public CName OnAnimEvent { get; set;}

[REDProp("onGameplayEvent")]
public CName OnGameplayEvent { get; set;}

[REDProp("bothGameplayAndAnimEvent")]
public bool BothGameplayAndAnimEvent { get; set;}

[REDProp("onInitialize")]
public bool OnInitialize { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

[REDProp("onDeactivate")]
public bool OnDeactivate { get; set;}

[REDProp("onSuccess")]
public bool OnSuccess { get; set;}

[REDProp("onFailure")]
public bool OnFailure { get; set;}

[REDProp("delayEffect")]
public float DelayEffect { get; set;}

[REDProp("checkIfEffectIsPlaying")]
public bool CheckIfEffectIsPlaying { get; set;}

[REDProp("cameraShakeStrength")]
public float CameraShakeStrength { get; set;}

[REDProp("onTaggedEntity")]
public bool OnTaggedEntity { get; set;}

[REDProp("tagToFind")]
public CName TagToFind { get; set;}

[REDProp("animEventReceived")]
public bool AnimEventReceived { get; set;}

[REDProp("gameplayEventReceived")]
public bool GameplayEventReceived { get; set;}

#endregion
}
}