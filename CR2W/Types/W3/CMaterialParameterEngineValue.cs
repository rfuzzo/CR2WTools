using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMaterialParameterEngineValue : CMaterialBlock
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("valueType")]
public EMaterialEngineValueType ValueType { get; set;}

#endregion
}
}