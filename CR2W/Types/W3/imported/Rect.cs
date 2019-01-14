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
public class Rect 
{
#region RED Properties

[REDProp("m_left")]
public Int32 M_left { get; set;}

[REDProp("m_top")]
public Int32 M_top { get; set;}

[REDProp("m_right")]
public Int32 M_right { get; set;}

[REDProp("m_bottom")]
public Int32 M_bottom { get; set;}

#endregion
}
}