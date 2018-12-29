using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4GwintGameMenu : CR4GwintBaseMenu
{
#region RED Properties

[REDProp("chooseTurnPopup")]
public Handle<W3ChooseGwintTurnPopup> ChooseTurnPopup { get; set;}

[REDProp("m_fxSetGwintResult")]
public Handle<CScriptedFlashFunction> M_fxSetGwintResult { get; set;}

[REDProp("m_fxSetWhoStarts")]
public Handle<CScriptedFlashFunction> M_fxSetWhoStarts { get; set;}

[REDProp("m_fxShowTutorial")]
public Handle<CScriptedFlashFunction> M_fxShowTutorial { get; set;}

[REDProp("playerWon")]
public bool PlayerWon { get; set;}

[REDProp("tutorialActive")]
public bool TutorialActive { get; set;}

#endregion
}
}