using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CIndexed2dArray : C2dArray
{
#region RED Properties

[REDProp("headers")]
public Array<string> Headers { get; set;}

[REDProp("data")]
public Array<Array<string>> Data { get; set;}

#endregion
}
}