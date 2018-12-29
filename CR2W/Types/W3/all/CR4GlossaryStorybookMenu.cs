using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4GlossaryStorybookMenu : CR4ListBaseMenu
{
#region RED Properties

[REDProp("allEntries")]
public Array<Handle<CJournalStoryBookChapter>> AllEntries { get; set;}

[REDProp("guiManager")]
public Handle<CR4GuiManager> GuiManager { get; set;}

[REDProp("bMovieIsPlaying")]
public bool BMovieIsPlaying { get; set;}

[REDProp("m_fxSetTitle")]
public Handle<CScriptedFlashFunction> M_fxSetTitle { get; set;}

[REDProp("m_fxSetText")]
public Handle<CScriptedFlashFunction> M_fxSetText { get; set;}

[REDProp("m_fxShowModules")]
public Handle<CScriptedFlashFunction> M_fxShowModules { get; set;}

#endregion
}
}