using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CCurve : CObject
{
#region RED Properties

[REDProp("color")]
public Color Color { get; set;}

[REDProp("dataBaseType")]
public ECurveBaseType DataBaseType { get; set;}

/*[REDProp("data.m_loop")]
public bool Data.m_loop { get; set;}*/

#endregion
}
}