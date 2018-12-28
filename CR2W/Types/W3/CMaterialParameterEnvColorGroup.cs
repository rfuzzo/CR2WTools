using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMaterialParameterEnvColorGroup : CMaterialBlock
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("colorGroup")]
public EEnvColorGroup ColorGroup { get; set;}

#endregion
}
}