using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4HudModuleSubtitles : CR4HudModuleBase
{
#region RED Properties

[REDProp("m_fxAddSubtitleSFF")]
public Handle<CScriptedFlashFunction> M_fxAddSubtitleSFF { get; set;}

[REDProp("m_fxRemoveSubtitleSFF")]
public Handle<CScriptedFlashFunction> M_fxRemoveSubtitleSFF { get; set;}

[REDProp("m_fxUpdateWidthSFF")]
public Handle<CScriptedFlashFunction> M_fxUpdateWidthSFF { get; set;}

#endregion
}
}