using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3DisplayMount : W3Container
{
#region RED Properties

[REDProp("ids")]
public Array<SItemUniqueId> Ids { get; set;}

[REDProp("i")]
public Int32 I { get; set;}

#endregion
}
}