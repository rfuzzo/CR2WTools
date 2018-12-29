using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3HouseGenericDecoration : W3HouseDecorationBase
{
#region RED Properties

[REDProp("m_itemFilterTag")]
public CName M_itemFilterTag { get; set;}

[REDProp("m_decorationItems")]
public Array<SHouseDecorationItemData> M_decorationItems { get; set;}

[REDProp("m_currentApperance")]
public CName M_currentApperance { get; set;}

#endregion
}
}