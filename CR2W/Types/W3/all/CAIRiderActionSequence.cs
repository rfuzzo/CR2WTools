using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIRiderActionSequence : IRiderActionTree
{
#region RED Properties

[REDProp("actions")]
public Array<Handle<IRiderActionTree>> Actions { get; set;}

#endregion
}
}