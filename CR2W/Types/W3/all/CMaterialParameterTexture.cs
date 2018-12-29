using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CMaterialParameterTexture : CMaterialParameter
{
#region RED Properties

[REDProp("sockets")]
public Array<Ptr<CGraphSocket>> Sockets { get; set;}

[REDProp("parameterName")]
public CName ParameterName { get; set;}

[REDProp("parameterGroup")]
public CName ParameterGroup { get; set;}

[REDProp("texture")]
public Handle<ITexture> Texture { get; set;}

[REDProp("isAtlas")]
public bool IsAtlas { get; set;}

#endregion
}
}