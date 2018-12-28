using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CAnimationSlots : CObject
{
#region RED Properties

[REDProp("name")]
public CName Name { get; set;}

[REDProp("transforms")]
public Array<Matrix> Transforms { get; set;}

#endregion
}
}