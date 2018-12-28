using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CDaycycleGraphicsEntity : CEntity
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

[REDProp("startStopEffects")]
public bool StartStopEffects { get; set;}

[REDProp("startStopLightsAndEngineValues")]
public bool StartStopLightsAndEngineValues { get; set;}

[REDProp("startEmissiveHour")]
public float StartEmissiveHour { get; set;}

[REDProp("startEmissiveFadeTime")]
public float StartEmissiveFadeTime { get; set;}

[REDProp("endEmissiveHour")]
public float EndEmissiveHour { get; set;}

[REDProp("endEmissiveFadeTime")]
public float EndEmissiveFadeTime { get; set;}

[REDProp("randomRange")]
public float RandomRange { get; set;}

[REDProp("flickeringPeriod")]
public float FlickeringPeriod { get; set;}

[REDProp("lightBrightnessWhenOnMin")]
public float LightBrightnessWhenOnMin { get; set;}

[REDProp("lightBrightnessWhenOnMax")]
public float LightBrightnessWhenOnMax { get; set;}

[REDProp("lightRandomOffsetX")]
public float LightRandomOffsetX { get; set;}

[REDProp("lightRandomOffsetY")]
public float LightRandomOffsetY { get; set;}

[REDProp("lightRandomOffsetZ")]
public float LightRandomOffsetZ { get; set;}

[REDProp("lightRadius")]
public float LightRadius { get; set;}

[REDProp("lightAutoHideDistance")]
public float LightAutoHideDistance { get; set;}

[REDProp("lightAutoHideRange")]
public float LightAutoHideRange { get; set;}

[REDProp("overrideRadius")]
public bool OverrideRadius { get; set;}

[REDProp("particleAlphaWhenOnMin")]
public float ParticleAlphaWhenOnMin { get; set;}

[REDProp("particleAlphaWhenOnMax")]
public float ParticleAlphaWhenOnMax { get; set;}

[REDProp("particleAlphaWhenOff")]
public float ParticleAlphaWhenOff { get; set;}

[REDProp("engineValueXWhenOnMin")]
public float EngineValueXWhenOnMin { get; set;}

[REDProp("engineValueXWhenOnMax")]
public float EngineValueXWhenOnMax { get; set;}

[REDProp("engineValueXWhenOff")]
public float EngineValueXWhenOff { get; set;}

[REDProp("engineValueYWhenOn")]
public float EngineValueYWhenOn { get; set;}

[REDProp("engineValueYWhenOff")]
public float EngineValueYWhenOff { get; set;}

[REDProp("engineValueZWhenOn")]
public float EngineValueZWhenOn { get; set;}

[REDProp("engineValueZWhenOff")]
public float EngineValueZWhenOff { get; set;}

[REDProp("engineValueWWhenOn")]
public float EngineValueWWhenOn { get; set;}

[REDProp("engineValueWWhenOff")]
public float EngineValueWWhenOff { get; set;}

[REDProp("engineValueColorWhenOn")]
public Color EngineValueColorWhenOn { get; set;}

[REDProp("engineValueColorWhenOff")]
public Color EngineValueColorWhenOff { get; set;}

#endregion
}
}