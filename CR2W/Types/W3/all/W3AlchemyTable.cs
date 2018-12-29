using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3AlchemyTable : CR4MapPinEntity
{
#region RED Properties

[REDProp("m_tableState")]
public W3TableState M_tableState { get; set;}

#endregion
}
}