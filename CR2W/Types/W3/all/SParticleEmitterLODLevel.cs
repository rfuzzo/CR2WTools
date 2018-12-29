using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class SParticleEmitterLODLevel 
{
#region RED Properties

[REDProp("emitterDurationSettings")]
public EmitterDurationSettings EmitterDurationSettings { get; set;}

[REDProp("emitterDelaySettings")]
public EmitterDelaySettings EmitterDelaySettings { get; set;}

[REDProp("burstList")]
public Array<ParticleBurst> BurstList { get; set;}

[REDProp("birthRate")]
public Ptr<IEvaluatorFloat> BirthRate { get; set;}

[REDProp("sortBackToFront")]
public bool SortBackToFront { get; set;}

[REDProp("isEnabled")]
public bool IsEnabled { get; set;}

#endregion
}
}