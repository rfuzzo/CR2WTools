using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class TutorialBlockerData : TextPopupData
{
#region RED Properties

[REDProp("m_title")]
public string M_title { get; set;}

[REDProp("m_description")]
public string M_description { get; set;}

[REDProp("m_imagepath")]
public string M_imagepath { get; set;}

[REDProp("scriptTag")]
public CName ScriptTag { get; set;}

[REDProp("managerRef")]
public Handle<CR4TutorialSystem> ManagerRef { get; set;}

#endregion
}
}