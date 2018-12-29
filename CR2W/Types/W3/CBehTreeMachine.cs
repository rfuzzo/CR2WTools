using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeMachine : CObject
{
#region RED Properties

[REDProp("instance")]
public Ptr<CBehTreeInstance> Instance { get; set;}

[REDProp("aiRes")]
public Handle<CBehTree> AiRes { get; set;}

[REDProp("aiParameters")]
public Array<Handle<IAIParameters>> AiParameters { get; set;}

#endregion
}
}