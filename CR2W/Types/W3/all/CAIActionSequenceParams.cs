using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]
public class CAIActionSequenceParams : IAIActionParameters
{
#region RED Properties

[REDProp("actions")]
public Array<Handle<IAIActionTree>> Actions { get; set;}

#endregion
}
}