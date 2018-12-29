using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class W3UIContext : CObject
{
#region RED Properties

[REDProp("m_inputBindings")]
public Array<SKeyBinding> M_inputBindings { get; set;}

[REDProp("m_contextBindings")]
public Array<SKeyBinding> M_contextBindings { get; set;}

[REDProp("m_managerRef")]
public Handle<W3ContextManager> M_managerRef { get; set;}

#endregion
}
}