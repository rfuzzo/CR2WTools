using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ArmorStand : W3HouseDecorationBase
{
#region RED Properties

[REDProp("m_mountAllItems")]
public bool M_mountAllItems { get; set;}

#endregion
}
}