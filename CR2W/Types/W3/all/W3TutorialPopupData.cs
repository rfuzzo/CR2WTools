using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialPopupData : CObject
{
#region RED Properties

[REDProp("posX")]
public float PosX { get; set;}

[REDProp("posY")]
public float PosY { get; set;}

[REDProp("messageTitle")]
public string MessageTitle { get; set;}

[REDProp("messageText")]
public string MessageText { get; set;}

[REDProp("imagePath")]
public string ImagePath { get; set;}

[REDProp("fadeBackground")]
public bool FadeBackground { get; set;}

[REDProp("autosize")]
public bool Autosize { get; set;}

[REDProp("enableGlossoryLink")]
public bool EnableGlossoryLink { get; set;}

[REDProp("enableAcceptButton")]
public bool EnableAcceptButton { get; set;}

[REDProp("canBeShownInMenus")]
public bool CanBeShownInMenus { get; set;}

[REDProp("blockInput")]
public bool BlockInput { get; set;}

[REDProp("pauseGame")]
public bool PauseGame { get; set;}

[REDProp("fullscreen")]
public bool Fullscreen { get; set;}

[REDProp("duration")]
public float Duration { get; set;}

[REDProp("scriptTag")]
public CName ScriptTag { get; set;}

[REDProp("menuRef")]
public Handle<CR4TutorialPopup> MenuRef { get; set;}

[REDProp("managerRef")]
public Handle<CR4TutorialSystem> ManagerRef { get; set;}

[REDProp("closeRequested")]
public bool CloseRequested { get; set;}

[REDProp("highlightedAreas")]
public Array<TutorialHighlightedArea> HighlightedAreas { get; set;}

#endregion
}
}