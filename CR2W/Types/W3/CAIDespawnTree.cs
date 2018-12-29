using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CAIDespawnTree : IAIActionTree
{
#region RED Properties

[REDProp("aiTreeName")]
public string AiTreeName { get; set;}

[REDProp("tree")]
public Handle<CBehTree> Tree { get; set;}

[REDProp("params")]
public Handle<CAIDespawnParameters> Params { get; set;}

#endregion
}
}