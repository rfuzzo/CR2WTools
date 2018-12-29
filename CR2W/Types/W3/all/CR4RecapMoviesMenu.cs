using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4RecapMoviesMenu : CR4MenuBase
{
#region RED Properties

[REDProp("m_fxSetGameLogoLanguage")]
public Handle<CScriptedFlashFunction> M_fxSetGameLogoLanguage { get; set;}

[REDProp("m_fxSetSubtitles")]
public Handle<CScriptedFlashFunction> M_fxSetSubtitles { get; set;}

[REDProp("m_MovieData")]
public Array<SMovieData> M_MovieData { get; set;}

[REDProp("m_CurrentMovieID")]
public Int32 M_CurrentMovieID { get; set;}

[REDProp("guiManager")]
public Handle<CR4GuiManager> GuiManager { get; set;}

[REDProp("wasSkipped")]
public bool WasSkipped { get; set;}

[REDProp("languageName")]
public string LanguageName { get; set;}

#endregion
}
}