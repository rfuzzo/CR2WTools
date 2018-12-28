using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CGame : CObject
{
#region RED Properties

[REDProp("activeWorld")]
public Handle<CWorld> ActiveWorld { get; set;}

[REDProp("visualDebug")]
public Ptr<CVisualDebug> VisualDebug { get; set;}

[REDProp("inputManager")]
public Ptr<CInputManager> InputManager { get; set;}

[REDProp("timerScriptKeyword")]
public Ptr<CTimerScriptKeyword> TimerScriptKeyword { get; set;}

[REDProp("gameResource")]
public Handle<CGameResource> GameResource { get; set;}

#endregion
}
}