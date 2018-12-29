using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TraceGroundProjectile : W3AdvancedProjectile
{
#region RED Properties

[REDProp("samplingFreq")]
public float SamplingFreq { get; set;}

[REDProp("effectName")]
public CName EffectName { get; set;}

[REDProp("onRangedReachedDestroyAfter")]
public float OnRangedReachedDestroyAfter { get; set;}

[REDProp("deactivateOnCollisionWithVictim")]
public bool DeactivateOnCollisionWithVictim { get; set;}

[REDProp("comp")]
public Handle<CEffectDummyComponent> Comp { get; set;}

#endregion
}
}