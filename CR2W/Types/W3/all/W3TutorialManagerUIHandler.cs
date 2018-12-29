using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3TutorialManagerUIHandler : CObject
{
#region RED Properties

[REDProp("listeners")]
public Array<SUITutorial> Listeners { get; set;}

[REDProp("lastOpenedMenu")]
public CName LastOpenedMenu { get; set;}

[REDProp("isMenuOpened")]
public bool IsMenuOpened { get; set;}

[REDProp("postponedUnregisteredMenu")]
public CName PostponedUnregisteredMenu { get; set;}

#endregion
}
}