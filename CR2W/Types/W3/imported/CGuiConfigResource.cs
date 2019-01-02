using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CR2W.IO;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CGuiConfigResource : CResource
{
#region RED Properties

[REDProp("huds", 2,0)]
public Array<SHudDescription> Huds { get; set;}

[REDProp("menus", 2,0)]
public Array<SMenuDescription> Menus { get; set;}

[REDProp("popups", 2,0)]
public Array<SPopupDescription> Popups { get; set;}

[REDProp("scene")]
public SGuiSceneDescription Scene { get; set;}

#endregion
}
}