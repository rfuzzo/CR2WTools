using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class Rect 
{
#region RED Properties

[REDProp("m_left")]
public int M_left { get; set;}

[REDProp("m_top")]
public int M_top { get; set;}

[REDProp("m_right")]
public int M_right { get; set;}

[REDProp("m_bottom")]
public int M_bottom { get; set;}

#endregion
}
}