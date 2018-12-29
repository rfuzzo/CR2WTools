using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4MainCreditsMenu : CR4MenuBase
{
#region RED Properties

[REDProp("guiManager")]
public Handle<CR4GuiManager> GuiManager { get; set;}

[REDProp("m_fxSetSectionTextSFF")]
public Handle<CScriptedFlashFunction> M_fxSetSectionTextSFF { get; set;}

[REDProp("m_fxSetScrollingSpeedSFF")]
public Handle<CScriptedFlashFunction> M_fxSetScrollingSpeedSFF { get; set;}

[REDProp("m_fxAddScrollingTextSFF")]
public Handle<CScriptedFlashFunction> M_fxAddScrollingTextSFF { get; set;}

[REDProp("m_fxStartScrollingTextSFF")]
public Handle<CScriptedFlashFunction> M_fxStartScrollingTextSFF { get; set;}

[REDProp("m_fxChangedConstraintedStateSFF")]
public Handle<CScriptedFlashFunction> M_fxChangedConstraintedStateSFF { get; set;}

[REDProp("m_fxSetThankYouText")]
public Handle<CScriptedFlashFunction> M_fxSetThankYouText { get; set;}

[REDProp("legalTextOverride")]
public bool LegalTextOverride { get; set;}

[REDProp("shouldCloseOnMovieEnd")]
public bool ShouldCloseOnMovieEnd { get; set;}

[REDProp("creditsSections")]
public Array<CreditsSection> CreditsSections { get; set;}

[REDProp("currentSectionID")]
public Int32 CurrentSectionID { get; set;}

[REDProp("htmlNewline")]
public string HtmlNewline { get; set;}

[REDProp("playedSecondSection")]
public bool PlayedSecondSection { get; set;}

[REDProp("SCROLLING_TEXT_LINE_COUNT")]
public Int32 SCROLLING_TEXT_LINE_COUNT { get; set;}

[REDProp("SCROLLING_SPEED")]
public Int32 SCROLLING_SPEED { get; set;}

#endregion
}
}