using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4OverlayMenu : CR4MenuBase
{
#region RED Properties

[REDProp("m_BlurBackground")]
public bool M_BlurBackground { get; set;}

[REDProp("m_PauseGame")]
public bool M_PauseGame { get; set;}

#endregion
}
}