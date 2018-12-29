using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class FocusModeCameraShotHelper : CObject
{
#region RED Properties

[REDProp("headingOffset")]
public float HeadingOffset { get; set;}

[REDProp("e")]
public Handle<CNewNPC> E { get; set;}

[REDProp("p")]
public Handle<CPlayer> P { get; set;}

[REDProp("initShot_yaw")]
public float InitShot_yaw { get; set;}

[REDProp("initShot_yawAlt")]
public float InitShot_yawAlt { get; set;}

[REDProp("initShot_yawA")]
public float InitShot_yawA { get; set;}

[REDProp("initShot_yawB")]
public float InitShot_yawB { get; set;}

[REDProp("initShot_yawC")]
public float InitShot_yawC { get; set;}

[REDProp("initShot_yawD")]
public float InitShot_yawD { get; set;}

[REDProp("initShot_number")]
public Int32 InitShot_number { get; set;}

[REDProp("initShot_isPlayerMainChar")]
public bool InitShot_isPlayerMainChar { get; set;}

[REDProp("initShot_mainCharacter")]
public Handle<CActor> InitShot_mainCharacter { get; set;}

[REDProp("initShot_secCharacter")]
public Handle<CActor> InitShot_secCharacter { get; set;}

[REDProp("initShot_cameraSecSide")]
public bool InitShot_cameraSecSide { get; set;}

[REDProp("ssShot_yaw")]
public float SsShot_yaw { get; set;}

[REDProp("ssShot_pitch")]
public float SsShot_pitch { get; set;}

[REDProp("ssShot_distance")]
public float SsShot_distance { get; set;}

[REDProp("ssShot_pivot")]
public Vector SsShot_pivot { get; set;}

[REDProp("blendShot_started")]
public bool BlendShot_started { get; set;}

[REDProp("blendShot_duration")]
public float BlendShot_duration { get; set;}

[REDProp("blendShot_timer")]
public float BlendShot_timer { get; set;}

[REDProp("blendShot_progress")]
public float BlendShot_progress { get; set;}

#endregion
}
}