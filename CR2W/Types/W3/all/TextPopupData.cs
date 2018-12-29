using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class TextPopupData : W3PopupData
{
#region RED Properties

[REDProp("m_TextContent")]
public string M_TextContent { get; set;}

[REDProp("m_TextTitle")]
public string M_TextTitle { get; set;}

[REDProp("m_ImagePath")]
public string M_ImagePath { get; set;}

[REDProp("m_DisplayGreyBackground")]
public bool M_DisplayGreyBackground { get; set;}

#endregion
}
}