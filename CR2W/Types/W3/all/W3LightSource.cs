using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3LightSource : W3UsableItem
{
#region RED Properties

[REDProp("worldName")]
public string WorldName { get; set;}

#endregion
}
}