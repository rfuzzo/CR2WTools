using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class IBehaviorScript : CObject
{
#region RED Properties

[REDProp("inputFloatNum")]
public uint InputFloatNum { get; set;}

[REDProp("inputVectorNum")]
public uint InputVectorNum { get; set;}

#endregion
}
}