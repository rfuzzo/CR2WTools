using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4NoticeBoardMenu : CR4MenuBase
{
#region RED Properties

[REDProp("board")]
public Handle<W3NoticeBoard> Board { get; set;}

[REDProp("m_fxSetSelectedIndex")]
public Handle<CScriptedFlashFunction> M_fxSetSelectedIndex { get; set;}

[REDProp("m_fxSetTitle")]
public Handle<CScriptedFlashFunction> M_fxSetTitle { get; set;}

[REDProp("m_fxSetDescription")]
public Handle<CScriptedFlashFunction> M_fxSetDescription { get; set;}

#endregion
}
}