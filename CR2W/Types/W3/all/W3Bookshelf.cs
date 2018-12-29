using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3Bookshelf : W3SmartObject
{
#region RED Properties

[REDProp("m_booksRange")]
public Int32 M_booksRange { get; set;}

[REDProp("m_appearances")]
public Array<CName> M_appearances { get; set;}

#endregion
}
}