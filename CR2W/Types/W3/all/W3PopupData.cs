using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3PopupData : CObject
{
#region RED Properties

[REDProp("ButtonsDef")]
public Array<SKeyBinding> ButtonsDef { get; set;}

[REDProp("PopupRef")]
public Handle<CR4MenuPopup> PopupRef { get; set;}

[REDProp("ScreenPosX")]
public float ScreenPosX { get; set;}

[REDProp("ScreenPosY")]
public float ScreenPosY { get; set;}

[REDProp("BlurBackground")]
public bool BlurBackground { get; set;}

[REDProp("PauseGame")]
public bool PauseGame { get; set;}

[REDProp("HideTutorial")]
public bool HideTutorial { get; set;}

#endregion
}
}