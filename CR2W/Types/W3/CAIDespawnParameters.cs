using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CAIDespawnParameters : IAIActionParameters
{
#region RED Properties

[REDProp("despawnAction")]
public Handle<IAIActionTree> DespawnAction { get; set;}

#endregion
}
}