using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CFXTrackItemParticles : CFXTrackItem
{
#region RED Properties

[REDProp("timeBegin")]
public float TimeBegin { get; set;}

[REDProp("timeDuration")]
public float TimeDuration { get; set;}

[REDProp("particleSystem")]
public Soft<CParticleSystem> ParticleSystem { get; set;}

[REDProp("spawner")]
public Ptr<IFXSpawner> Spawner { get; set;}

#endregion
}
}