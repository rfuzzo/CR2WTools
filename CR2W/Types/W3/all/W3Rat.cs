using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Rat : CNewNPC
{
#region RED Properties

[REDProp("hasCollision")]
public bool HasCollision { get; set;}

#endregion
}
}