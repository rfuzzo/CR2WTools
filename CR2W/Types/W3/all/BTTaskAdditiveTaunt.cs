using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class BTTaskAdditiveTaunt : IBehTreeTask
{
#region RED Properties

[REDProp("distMin")]
public float DistMin { get; set;}

[REDProp("distMax")]
public float DistMax { get; set;}

#endregion
}
}