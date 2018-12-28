using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class CMaterialParameterCube : CMaterialParameter
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("parameterName")]
public CName ParameterName { get; set;}

[REDProp("parameterGroup")]
public CName ParameterGroup { get; set;}

[REDProp("cube")]
public Handle<CCubeTexture> Cube { get; set;}

#endregion
}
}