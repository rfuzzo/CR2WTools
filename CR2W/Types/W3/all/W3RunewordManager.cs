using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3RunewordManager : CObject
{
#region RED Properties

[REDProp("runewords")]
public Array<Runeword> Runewords { get; set;}

#endregion
}
}