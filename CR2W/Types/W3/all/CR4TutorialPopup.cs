using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4TutorialPopup : CR4PopupBase
{
#region RED Properties

[REDProp("m_DataObject")]
public Handle<W3TutorialPopupData> M_DataObject { get; set;}

[REDProp("timeRemains")]
public float TimeRemains { get; set;}

[REDProp("removeOnTimer")]
public bool RemoveOnTimer { get; set;}

[REDProp("enableGlossaryLink")]
public bool EnableGlossaryLink { get; set;}

[REDProp("hideCounter")]
public Int32 HideCounter { get; set;}

[REDProp("forcedhideCounter")]
public Int32 ForcedhideCounter { get; set;}

[REDProp("isVisible")]
public bool IsVisible { get; set;}

[REDProp("m_fxPlayFeedbackAnim")]
public Handle<CScriptedFlashFunction> M_fxPlayFeedbackAnim { get; set;}

[REDProp("m_fxResetInput")]
public Handle<CScriptedFlashFunction> M_fxResetInput { get; set;}

[REDProp("m_contextStored")]
public bool M_contextStored { get; set;}

#endregion
}
}