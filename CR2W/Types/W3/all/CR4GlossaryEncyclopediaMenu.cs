using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4GlossaryEncyclopediaMenu : CR4ListBaseMenu
{
#region RED Properties

[REDProp("m_fxUpdateEntryInfo")]
public Handle<CScriptedFlashFunction> M_fxUpdateEntryInfo { get; set;}

[REDProp("m_fxUpdateEntryImage")]
public Handle<CScriptedFlashFunction> M_fxUpdateEntryImage { get; set;}

[REDProp("m_fxSetMovieData")]
public Handle<CScriptedFlashFunction> M_fxSetMovieData { get; set;}

#endregion
}
}