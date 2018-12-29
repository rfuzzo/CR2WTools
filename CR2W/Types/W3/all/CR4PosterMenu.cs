using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4PosterMenu : CR4MenuBase
{
#region RED Properties

[REDProp("m_posterEntity")]
public Handle<W3Poster> M_posterEntity { get; set;}

[REDProp("m_fxSetDescriptionSFF")]
public Handle<CScriptedFlashFunction> M_fxSetDescriptionSFF { get; set;}

[REDProp("m_fxSetSubtitlesHackSFF")]
public Handle<CScriptedFlashFunction> M_fxSetSubtitlesHackSFF { get; set;}

#endregion
}
}