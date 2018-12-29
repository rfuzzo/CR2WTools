using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CInputAxisDoubleTap : CObject
{
#region RED Properties

[REDProp("m_ActionN")]
public CName M_ActionN { get; set;}

[REDProp("m_ThresholdUnpressF")]
public float M_ThresholdUnpressF { get; set;}

[REDProp("m_ThresholdPressF")]
public float M_ThresholdPressF { get; set;}

[REDProp("m_TimeThresholdF")]
public float M_TimeThresholdF { get; set;}

[REDProp("m_IsActivatedB")]
public bool M_IsActivatedB { get; set;}

[REDProp("m_PressedNowB")]
public bool M_PressedNowB { get; set;}

[REDProp("m_UnpressedNowB")]
public bool M_UnpressedNowB { get; set;}

[REDProp("m_TimeF")]
public float M_TimeF { get; set;}

[REDProp("m_LastTimesUnpressFArr")]
public Array<float> M_LastTimesUnpressFArr { get; set;}

[REDProp("m_LastTimesPressFArr")]
public Array<float> M_LastTimesPressFArr { get; set;}

#endregion
}
}