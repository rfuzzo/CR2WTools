using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CGuiConfigResource : CResource
{
#region RED Properties

[REDProp("huds")]
public Array<SHudDescription> Huds { get; set;}

[REDProp("menus")]
public Array<SMenuDescription> Menus { get; set;}

[REDProp("popups")]
public Array<SPopupDescription> Popups { get; set;}

[REDProp("scene")]
public SGuiSceneDescription Scene { get; set;}

#endregion
}
}