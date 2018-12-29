using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4GlossaryBestiaryMenu : CR4ListBaseMenu
{
#region RED Properties

[REDProp("allCreatures")]
public Array<Handle<CJournalCreature>> AllCreatures { get; set;}

[REDProp("m_fxHideContent")]
public Handle<CScriptedFlashFunction> M_fxHideContent { get; set;}

[REDProp("m_fxSetTitle")]
public Handle<CScriptedFlashFunction> M_fxSetTitle { get; set;}

[REDProp("m_fxSetText")]
public Handle<CScriptedFlashFunction> M_fxSetText { get; set;}

[REDProp("m_fxSetImage")]
public Handle<CScriptedFlashFunction> M_fxSetImage { get; set;}

#endregion
}
}