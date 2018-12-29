using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CR4MainDbgStartQuestMenu : CR4MenuBase
{
#region RED Properties

[REDProp("m_optionsNames")]
public Array<CName> M_optionsNames { get; set;}

[REDProp("m_gameResources")]
public Array<string> M_gameResources { get; set;}

#endregion
}
}