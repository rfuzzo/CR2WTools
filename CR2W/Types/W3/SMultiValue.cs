using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CR2W.Types.W3
{
public class SMultiValue 
{
#region RED Properties

[REDProp("floats")]
public Array<float> Floats { get; set;}

[REDProp("bools")]
public Array<bool> Bools { get; set;}

[REDProp("enums")]
public Array<SEnumVariant> Enums { get; set;}

[REDProp("names")]
public Array<CName> Names { get; set;}

#endregion
}
}