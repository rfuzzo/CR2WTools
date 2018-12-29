using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4StartScreenMenuBase : CR4MenuBase
{
#region RED Properties

[REDProp("_fadeDuration")]
public float _fadeDuration { get; set;}

[REDProp("m_fxSetFadeDuration")]
public Handle<CScriptedFlashFunction> M_fxSetFadeDuration { get; set;}

[REDProp("m_fxSetIsStageDemo")]
public Handle<CScriptedFlashFunction> M_fxSetIsStageDemo { get; set;}

[REDProp("m_fxStartFade")]
public Handle<CScriptedFlashFunction> M_fxStartFade { get; set;}

[REDProp("m_fxSetGameLogoLanguage")]
public Handle<CScriptedFlashFunction> M_fxSetGameLogoLanguage { get; set;}

[REDProp("m_fxSetText")]
public Handle<CScriptedFlashFunction> M_fxSetText { get; set;}

#endregion
}
}