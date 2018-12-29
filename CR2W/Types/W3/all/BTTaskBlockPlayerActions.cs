using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskBlockPlayerActions : IBehTreeTask
{
#region RED Properties

[REDProp("block")]
public bool Block { get; set;}

[REDProp("onActivate")]
public bool OnActivate { get; set;}

#endregion
}
}