using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class IActorConditionType : CObject
{
#region RED Properties

[REDProp("inverted")]
public bool Inverted { get; set;}

#endregion
}
}