using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4CommonIngameMenu : CR4MenuBase
{
#region RED Properties

[REDProp("m_menuData")]
public Array<SMenuTab> M_menuData { get; set;}

[REDProp("currentMenuName")]
public CName CurrentMenuName { get; set;}

[REDProp("reopenRequested")]
public bool ReopenRequested { get; set;}

#endregion
}
}