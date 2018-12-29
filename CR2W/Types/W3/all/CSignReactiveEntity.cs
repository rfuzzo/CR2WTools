using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CSignReactiveEntity : W3MonsterClue
{
#region RED Properties

[REDProp("factOnSignCast")]
public string FactOnSignCast { get; set;}

[REDProp("igni")]
public bool Igni { get; set;}

[REDProp("aard")]
public bool Aard { get; set;}

[REDProp("clueActionWhenDestroyed")]
public EClueOperation ClueActionWhenDestroyed { get; set;}

[REDProp("igniteOnInteraction")]
public bool IgniteOnInteraction { get; set;}

[REDProp("destroyingTimeout")]
public float DestroyingTimeout { get; set;}

[REDProp("destroyedEffectsTimeout")]
public float DestroyedEffectsTimeout { get; set;}

[REDProp("destroyingEffectName")]
public CName DestroyingEffectName { get; set;}

[REDProp("destroyedEffectName")]
public CName DestroyedEffectName { get; set;}

[REDProp("isDestroyed")]
public bool IsDestroyed { get; set;}

[REDProp("clueActionArray")]
public Array<EClueOperation> ClueActionArray { get; set;}

[REDProp("currentAppearance")]
public string CurrentAppearance { get; set;}

[REDProp("interactionComponents")]
public Array<Handle<CComponent>> InteractionComponents { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

#endregion
}
}