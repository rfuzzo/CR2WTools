using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CR4Game : CCommonGame
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

[REDProp("player")]
public Handle<CPlayer> Player { get; set;}

[REDProp("dlcManager")]
public Ptr<CDLCManager> DlcManager { get; set;}

[REDProp("horseCamera")]
public Handle<CCustomCamera> HorseCamera { get; set;}

[REDProp("telemetryScriptProxy")]
public Ptr<CR4TelemetryScriptProxy> TelemetryScriptProxy { get; set;}

[REDProp("secondScreenScriptProxy")]
public Ptr<CR4SecondScreenManagerScriptProxy> SecondScreenScriptProxy { get; set;}

[REDProp("kinectSpeechRecognizerListenerScriptProxy")]
public Ptr<CR4KinectSpeechRecognizerListenerScriptProxy> KinectSpeechRecognizerListenerScriptProxy { get; set;}

[REDProp("ticketsDefaultConfiguration")]
public Ptr<CTicketsDefaultConfiguration> TicketsDefaultConfiguration { get; set;}

[REDProp("globalEventsScriptsDispatcher")]
public Ptr<CR4GlobalEventsScriptsDispatcher> GlobalEventsScriptsDispatcher { get; set;}

[REDProp("worldDLCExtender")]
public Ptr<CR4WorldDLCExtender> WorldDLCExtender { get; set;}

[REDProp("globalTicketSource")]
public Handle<CGlabalTicketSourceProvider> GlobalTicketSource { get; set;}

[REDProp("carryableItemsRegistry")]
public Handle<CCarryableItemsRegistry> CarryableItemsRegistry { get; set;}

[REDProp("params")]
public Handle<W3GameParams> Params { get; set;}

#endregion
}
}