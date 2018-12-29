using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4DeckBuilderMenu : CR4GwintBaseMenu
{
#region RED Properties

[REDProp("m_fxSetSelectedDeck")]
public Handle<CScriptedFlashFunction> M_fxSetSelectedDeck { get; set;}

[REDProp("m_fxSetGwintGamePending")]
public Handle<CScriptedFlashFunction> M_fxSetGwintGamePending { get; set;}

[REDProp("m_fxShowTutorial")]
public Handle<CScriptedFlashFunction> M_fxShowTutorial { get; set;}

[REDProp("m_fxContinueTutorial")]
public Handle<CScriptedFlashFunction> M_fxContinueTutorial { get; set;}

[REDProp("m_fxSetPassiveAbilString")]
public Handle<CScriptedFlashFunction> M_fxSetPassiveAbilString { get; set;}

#endregion
}
}