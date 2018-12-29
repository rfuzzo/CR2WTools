using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3MainMenuInitData : W3MenuInitData
{
#region RED Properties

[REDProp("m_panelXOffset")]
public Int32 M_panelXOffset { get; set;}

#endregion
}
}