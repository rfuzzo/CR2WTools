using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3ContextManager : CObject
{
#region RED Properties

[REDProp("m_currentContext")]
public Handle<W3UIContext> M_currentContext { get; set;}

[REDProp("m_commonMenuRef")]
public Handle<CR4CommonMenu> M_commonMenuRef { get; set;}

#endregion
}
}