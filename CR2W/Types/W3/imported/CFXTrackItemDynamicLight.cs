using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CFXTrackItemDynamicLight : CFXTrackItemCurveBase
{
#region RED Properties

[REDProp("timeBegin")]
public float TimeBegin { get; set;}

[REDProp("timeDuration")]
public float TimeDuration { get; set;}

[REDProp("color")]
public Color Color { get; set;}

[REDProp("radius")]
public float Radius { get; set;}

[REDProp("brightness")]
public float Brightness { get; set;}

[REDProp("attenuation")]
public float Attenuation { get; set;}

[REDProp("specularScale")]
public float SpecularScale { get; set;}

[REDProp("lightChannels")]
public ELightChannel LightChannels { get; set;}

[REDProp("isCastingShadows")]
public bool IsCastingShadows { get; set;}

[REDProp("isModulative")]
public bool IsModulative { get; set;}

[REDProp("lightFlickering")]
public SLightFlickering LightFlickering { get; set;}

[REDProp("autoHideDistance")]
public float AutoHideDistance { get; set;}

[REDProp("autoHideRange")]
public float AutoHideRange { get; set;}

[REDProp("colorGroup")]
public EEnvColorGroup ColorGroup { get; set;}

[REDProp("isSpotlight")]
public bool IsSpotlight { get; set;}

[REDProp("spotInnerAngle")]
public float SpotInnerAngle { get; set;}

[REDProp("spotOuterAngle")]
public float SpotOuterAngle { get; set;}

[REDProp("spawner")]
public Ptr<IFXSpawner> Spawner { get; set;}

#endregion
}
}