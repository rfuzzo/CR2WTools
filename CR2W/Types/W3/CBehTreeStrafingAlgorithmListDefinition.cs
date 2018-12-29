using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CR2W.Types.W3
{
[TypeConverter(typeof(ExpandableObjectConverter))]public class CBehTreeStrafingAlgorithmListDefinition : CBehTreeStrafingAlgorithmDefinition
{
#region RED Properties

[REDProp("list")]
public Array<Ptr<CBehTreeStrafingAlgorithmDefinition>> List { get; set;}

#endregion
}
}