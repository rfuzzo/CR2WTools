using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CBrushCompiledData : CObject
{
#region RED Properties

[REDProp("brushes")]
public Array<Ptr<CBrushComponent>> Brushes { get; set;}

#endregion
}
}