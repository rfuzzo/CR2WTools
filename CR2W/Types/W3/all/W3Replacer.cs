using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Replacer : CR4Player
{
#region RED Properties

[REDProp("level")]
public Int32 Level { get; set;}

#endregion
}
}