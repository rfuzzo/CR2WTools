using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CMaterialParameterVector : CMaterialParameter
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("parameterName")]
public CName ParameterName { get; set;}

[REDProp("parameterGroup")]
public CName ParameterGroup { get; set;}

[REDProp("vector")]
public Vector Vector { get; set;}

[REDProp("useInVertexShader")]
public bool UseInVertexShader { get; set;}

#endregion
}
}