using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4GwintBaseMenu : CR4MenuBase
{
#region RED Properties

[REDProp("quitConfPopup")]
public Handle<W3GwintQuitConfPopup> QuitConfPopup { get; set;}

[REDProp("gwintManager")]
public Handle<CR4GwintManager> GwintManager { get; set;}

[REDProp("flashConstructor")]
public Handle<CScriptedFlashObject> FlashConstructor { get; set;}

#endregion
}
}